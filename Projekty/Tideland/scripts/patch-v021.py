from pathlib import Path
import json,re

ROOT=Path('Projekty/Tideland')

def read(rel): return (ROOT/rel).read_text()
def write(rel,text): (ROOT/rel).write_text(text)
def replace_one(rel,old,new):
    text=read(rel)
    count=text.count(old)
    if count!=1: raise SystemExit(f'{rel}: expected 1 exact match, got {count}')
    write(rel,text.replace(old,new,1))
def sub_one(rel,pattern,repl,flags=0):
    text=read(rel)
    new,count=re.subn(pattern,repl,text,count=1,flags=flags)
    if count!=1: raise SystemExit(f'{rel}: expected 1 regex match, got {count}')
    write(rel,new)

# Conventional FPS FOV: the user-facing value is horizontal at 16:9. Three.js wants vertical.
write('src/camera/FirstPersonProjection.ts',"""import {MathUtils,PerspectiveCamera} from 'three';

/** Player-facing horizontal FOV at the 16:9 reference aspect. */
export const FOV_REFERENCE_ASPECT=16/9;
export const FOV_MIN=70,FOV_MAX=120,FOV_DEFAULT=90;
export function normalizeFov(value:number):number{return Number.isFinite(value)?MathUtils.clamp(value,FOV_MIN,FOV_MAX):FOV_DEFAULT;}
export function worldVerticalFov(horizontalAt169:number):number{
  return MathUtils.radToDeg(2*Math.atan(Math.tan(MathUtils.degToRad(normalizeFov(horizontalAt169))/2)/FOV_REFERENCE_ASPECT));
}
export function horizontalFov(vertical:number,aspect:number):number{
  return MathUtils.radToDeg(2*Math.atan(Math.tan(MathUtils.degToRad(vertical)/2)*Math.max(.1,aspect)));
}

/** Sole writer of the world camera projection. */
export class FirstPersonProjection {
  private base=FOV_DEFAULT;
  private sprintOffset=0;
  private sprintBoost=2;
  constructor(readonly camera:PerspectiveCamera){this.apply();}
  setBaseFov(value:number){this.base=normalizeFov(value);this.apply();}
  setSprintBoost(value:number){this.sprintBoost=MathUtils.clamp(Number.isFinite(value)?value:2,0,8);}
  resize(aspect:number){this.camera.aspect=Math.max(.1,aspect);this.apply();}
  update(dt:number,sprinting:boolean){
    const maxBoost=Math.max(0,FOV_MAX-this.base);
    const target=sprinting?Math.min(this.sprintBoost,maxBoost):0;
    this.sprintOffset=MathUtils.damp(this.sprintOffset,target,10,dt);
    if(Math.abs(this.sprintOffset-target)<.001)this.sprintOffset=target;
    this.apply();
  }
  private apply(){
    const horizontal=normalizeFov(this.base+this.sprintOffset);
    const vertical=worldVerticalFov(horizontal);
    if(Math.abs(this.camera.fov-vertical)>.00001)this.camera.fov=vertical;
    this.camera.updateProjectionMatrix();
  }
}
""")

replace_one('src/core/types.ts',
"export interface Settings {sensitivity:number; fov:number; masterVolume:number; effectsVolume:number; quality:'low'|'medium'|'high'}",
"export interface Settings {sensitivity:number; fov:number; viewmodelFov:number; sprintFovBoost:number; headBob:boolean; invertY:boolean; masterVolume:number; effectsVolume:number; quality:'low'|'medium'|'high'; renderScale:number; shadows:boolean; crosshairOpacity:number; showCompass:boolean}")

replace_one('src/config/balance.ts',
"export const DEFAULT_SETTINGS = {sensitivity:1,fov:90,masterVolume:0.65,effectsVolume:0.7,quality:'high' as const};",
"export const DEFAULT_SETTINGS = {sensitivity:1,fov:90,viewmodelFov:50,sprintFovBoost:2,headBob:false,invertY:false,masterVolume:0.65,effectsVolume:0.7,quality:'high' as const,renderScale:1,shadows:true,crosshairOpacity:0.8,showCompass:true};")

sub_one('src/save/storage.ts',r"function normalizeSettings\(value: unknown\): Settings \{.*?\n\}\n\nexport function loadSettings",'''function normalizeSettings(value: unknown): Settings {
  if (!record(value)) return { ...DEFAULT_SETTINGS };
  return {
    sensitivity: finite(value.sensitivity, 0.2, 3) ? value.sensitivity : DEFAULT_SETTINGS.sensitivity,
    fov: finite(value.fov, 60, 130) ? normalizeFov(value.fov) : DEFAULT_SETTINGS.fov,
    viewmodelFov: finite(value.viewmodelFov, 40, 80) ? value.viewmodelFov : DEFAULT_SETTINGS.viewmodelFov,
    sprintFovBoost: finite(value.sprintFovBoost, 0, 8) ? value.sprintFovBoost : DEFAULT_SETTINGS.sprintFovBoost,
    headBob: typeof value.headBob === 'boolean' ? value.headBob : DEFAULT_SETTINGS.headBob,
    invertY: typeof value.invertY === 'boolean' ? value.invertY : DEFAULT_SETTINGS.invertY,
    masterVolume: finite(value.masterVolume, 0, 1) ? value.masterVolume : DEFAULT_SETTINGS.masterVolume,
    effectsVolume: finite(value.effectsVolume, 0, 1) ? value.effectsVolume : DEFAULT_SETTINGS.effectsVolume,
    quality: value.quality === 'low' || value.quality === 'medium' || value.quality === 'high' ? value.quality : DEFAULT_SETTINGS.quality,
    renderScale: finite(value.renderScale, 0.5, 1.25) ? value.renderScale : DEFAULT_SETTINGS.renderScale,
    shadows: typeof value.shadows === 'boolean' ? value.shadows : DEFAULT_SETTINGS.shadows,
    crosshairOpacity: finite(value.crosshairOpacity, 0.2, 1) ? value.crosshairOpacity : DEFAULT_SETTINGS.crosshairOpacity,
    showCompass: typeof value.showCompass === 'boolean' ? value.showCompass : DEFAULT_SETTINGS.showCompass,
  };
}

export function loadSettings''',re.S)

# Mouse options and head bob are live settings.
replace_one('src/player/PlayerController.ts',
"constructor(readonly physics:PhysicsWorld,readonly camera:THREE.PerspectiveCamera,private input:Input,private settings:Settings,state:GameState){this.yaw=state.player.yaw;this.pitch=state.player.pitch;this.currentEye.set(state.player.position.x,state.player.position.y+PLAYER.EYE_HEIGHT,state.player.position.z);this.previousEye.copy(this.currentEye);this.renderCamera(1);}",
"constructor(readonly physics:PhysicsWorld,readonly camera:THREE.PerspectiveCamera,private input:Input,private settings:Settings,state:GameState){this.yaw=state.player.yaw;this.pitch=state.player.pitch;this.headBob=settings.headBob;this.currentEye.set(state.player.position.x,state.player.position.y+PLAYER.EYE_HEIGHT,state.player.position.z);this.previousEye.copy(this.currentEye);this.renderCamera(1);}")
replace_one('src/player/PlayerController.ts',
"  look(dx:number,dy:number){this.yaw-=dx*0.002*this.settings.sensitivity;this.pitch=THREE.MathUtils.clamp(this.pitch-dy*0.002*this.settings.sensitivity,-1.48,1.48);this.camera.rotation.order='YXZ';this.camera.rotation.set(this.pitch,this.yaw,0);}",
"  look(dx:number,dy:number){const vertical=this.settings.invertY?-dy:dy;this.yaw-=dx*0.002*this.settings.sensitivity;this.pitch=THREE.MathUtils.clamp(this.pitch-vertical*0.002*this.settings.sensitivity,-1.48,1.48);this.camera.rotation.order='YXZ';this.camera.rotation.set(this.pitch,this.yaw,0);}")
replace_one('src/player/PlayerController.ts',"  setSettings(s:Settings){this.settings=s;}","  setSettings(s:Settings){this.settings=s;this.headBob=s.headBob;}")

# Separate first-person item FOV so the weapon/hand can be tuned independently.
replace_one('src/rendering/HeldItem.ts',"  hit(){this.swing=1;}","  setFov(value:number){this.camera.fov=THREE.MathUtils.clamp(Number.isFinite(value)?value:50,40,80);this.camera.updateProjectionMatrix();}\n  hit(){this.swing=1;}")

# Apply the expanded graphics/camera settings.
sub_one('src/app/GameApp.ts',r"  private applySettings\(s:Settings\)\{.*?\}\n  private resize\(\)",'''  private applySettings(s:Settings){
    this.settings={...s};
    this.projection.setBaseFov(s.fov);
    this.projection.setSprintBoost(s.sprintFovBoost);
    this.held.setFov(s.viewmodelFov);
    saveSettings(s);this.ui?.setSettings(s);this.audio?.setSettings(s);this.player?.setSettings(s);
    const qualityDpr=s.quality==='low'?1:s.quality==='medium'?Math.min(devicePixelRatio,1.25):Math.min(devicePixelRatio,1.6);
    this.renderer.setPixelRatio(Math.max(.5,Math.min(2,qualityDpr*s.renderScale)));
    this.renderer.shadowMap.enabled=s.shadows&&s.quality!=='low';
    this.environment?.setQuality(s.quality);
    this.resize();
  }
  private resize()''',re.S)

# Rebuild the settings screen with more useful FPS options.
ui=read('src/ui/UI.ts')
settings_section='''      <section class="screen settings-screen" data-view="settings" aria-label="Settings"><header class="overlay-header"><div class="small-brand">${mark}<span>TIDELAND</span><i>/</i><span class="muted">SETTINGS</span></div><button class="close-button" data-action="settingsBack">BACK <span>×</span></button></header><div class="settings-content"><div class="settings-intro"><div class="eyebrow">MAKE YOURSELF AT HOME</div><h2>LIVE<br>PREVIEW<span>.</span></h2><p>Camera, graphics and interface changes apply immediately.<br>Everything saves automatically on this device.</p></div><div class="settings-controls"><h3>CONTROLS & CAMERA</h3>${this.slider('sensitivity','Mouse sensitivity',0.2,3,0.1)}${this.slider('fov','Horizontal field of view <small>16:9 reference · conventional FPS FOV</small>',70,120,1)}${this.slider('viewmodelFov','Viewmodel field of view <small>Hands and equipped tools only</small>',40,80,1)}${this.slider('sprintFovBoost','Sprint FOV boost <small>Extra horizontal FOV while sprinting</small>',0,8,1)}${this.toggle('invertY','Invert vertical mouse','Reverse up/down mouse look')}${this.toggle('headBob','Head bob','Subtle camera movement while walking')}<h3>AUDIO</h3>${this.slider('masterVolume','Master volume',0,1,0.01)}${this.slider('effectsVolume','Effects volume',0,1,0.01)}<h3>GRAPHICS</h3><div class="setting-row quality-row"><label>Graphics quality<small>Vegetation detail and environment quality</small></label><div class="quality-options"><button data-quality="low">LOW</button><button data-quality="medium">MEDIUM</button><button data-quality="high">HIGH</button></div></div>${this.slider('renderScale','Render scale <small>Lower this for more FPS</small>',0.5,1.25,0.05)}${this.toggle('shadows','Dynamic shadows','Disabled automatically on LOW quality')}<h3>INTERFACE</h3>${this.slider('crosshairOpacity','Crosshair opacity',0.2,1,0.05)}${this.toggle('showCompass','Compass','Heading and biome strip at the top')}<div class="save-reset-row"><span>LOCAL SAVE DATA<small>Remove your saved island and progress.</small></span><button class="danger-button" data-action="reset">RESET SAVE</button></div><div class="reset-confirm" hidden><span>This permanently removes the saved world.</span><button data-action="resetConfirm">DELETE SAVE</button><button data-action="resetCancel">CANCEL</button></div></div></div></section>'''
ui,count=re.subn(r'      <section class="screen settings-screen".*?</section>\n\n      <section class="screen dead-screen"',settings_section+'\n\n      <section class="screen dead-screen"',ui,count=1,flags=re.S)
if count!=1: raise SystemExit('UI.ts settings section replacement failed')
write('src/ui/UI.ts',ui)

replace_one('src/ui/UI.ts',
"    for (const name of ['sensitivity','fov','masterVolume','effectsVolume'] as const) {\n      const input = this.find<HTMLInputElement>(`input[data-setting=\"${name}\"]`);\n      input.value = String(settings[name]);\n      this.find(`[data-setting-value=\"${name}\"]`).textContent = this.settingValue(name, settings[name]);\n      input.style.setProperty('--range',`${(settings[name] - Number(input.min)) / (Number(input.max) - Number(input.min)) * 100}%`);\n    }\n    this.root.querySelectorAll<HTMLElement>('[data-quality]').forEach(button => button.classList.toggle('active',button.dataset.quality === settings.quality));",
"    for (const name of ['sensitivity','fov','viewmodelFov','sprintFovBoost','masterVolume','effectsVolume','renderScale','crosshairOpacity'] as const) {\n      const input = this.find<HTMLInputElement>(`input[data-setting=\"${name}\"]`);\n      input.value = String(settings[name]);\n      this.find(`[data-setting-value=\"${name}\"]`).textContent = this.settingValue(name, settings[name]);\n      input.style.setProperty('--range',`${(settings[name] - Number(input.min)) / (Number(input.max) - Number(input.min)) * 100}%`);\n    }\n    this.root.querySelectorAll<HTMLElement>('[data-quality]').forEach(button => button.classList.toggle('active',button.dataset.quality === settings.quality));\n    for(const name of ['invertY','headBob','shadows','showCompass'] as const)this.root.querySelectorAll<HTMLElement>(`[data-toggle=\"${name}\"]`).forEach(button=>button.classList.toggle('active',button.dataset.value===String(settings[name])));\n    this.root.style.setProperty('--crosshair-opacity',String(settings.crosshairOpacity));\n    this.root.classList.toggle('hide-compass',!settings.showCompass);")

replace_one('src/ui/UI.ts',
"      if(target.dataset.quality) {this.settings.quality=target.dataset.quality as Settings['quality'];this.actions.settings({...this.settings});this.setSettings(this.settings);}\n      if(target.dataset.dev) this.actions.dev(target.dataset.dev);",
"      if(target.dataset.quality) {this.settings.quality=target.dataset.quality as Settings['quality'];this.actions.settings({...this.settings});this.setSettings(this.settings);}\n      if(target.dataset.toggle){const value=target.dataset.value==='true';switch(target.dataset.toggle){case 'invertY':this.settings.invertY=value;break;case 'headBob':this.settings.headBob=value;break;case 'shadows':this.settings.shadows=value;break;case 'showCompass':this.settings.showCompass=value;break;}this.actions.settings({...this.settings});this.setSettings(this.settings);}\n      if(target.dataset.dev) this.actions.dev(target.dataset.dev);")

sub_one('src/ui/UI.ts',r"    this\.root\.addEventListener\('input',event => \{\n      const input = event\.target as HTMLInputElement;\n      const name = input\.dataset\.setting as keyof Settings \| undefined;\n      if\(!name \|\| name === 'quality'\) return;\n      this\.settings\[name\] = Number\(input\.value\);\n      this\.actions\.settings\(\{\.\.\.this\.settings\}\);\n      this\.setSettings\(this\.settings\);\n    \}\);",'''    this.root.addEventListener('input',event => {
      const input=event.target as HTMLInputElement;const name=input.dataset.setting;const value=Number(input.value);
      switch(name){
        case 'sensitivity':this.settings.sensitivity=value;break;case 'fov':this.settings.fov=value;break;case 'viewmodelFov':this.settings.viewmodelFov=value;break;case 'sprintFovBoost':this.settings.sprintFovBoost=value;break;
        case 'masterVolume':this.settings.masterVolume=value;break;case 'effectsVolume':this.settings.effectsVolume=value;break;case 'renderScale':this.settings.renderScale=value;break;case 'crosshairOpacity':this.settings.crosshairOpacity=value;break;default:return;
      }
      this.actions.settings({...this.settings});this.setSettings(this.settings);
    });''')

replace_one('src/ui/UI.ts',
"  private slider(name: string, label: string, min: number, max: number, step: number): string {return `<div class=\"setting-row\"><label for=\"setting-${name}\">${label}</label><div class=\"setting-slider\"><input id=\"setting-${name}\" data-setting=\"${name}\" type=\"range\" min=\"${min}\" max=\"${max}\" step=\"${step}\"><output data-setting-value=\"${name}\"></output></div></div>`;}\n  private settingValue(name: string, value: number): string {return name.includes('Volume')?`${Math.round(value*100)}%`:name==='fov'?`${value}°`:`${value.toFixed(1)}×`;}",
"  private slider(name:string,label:string,min:number,max:number,step:number):string{return `<div class=\"setting-row\"><label for=\"setting-${name}\">${label}</label><div class=\"setting-slider\"><input id=\"setting-${name}\" data-setting=\"${name}\" type=\"range\" min=\"${min}\" max=\"${max}\" step=\"${step}\"><output data-setting-value=\"${name}\"></output></div></div>`;}\n  private toggle(name:'invertY'|'headBob'|'shadows'|'showCompass',label:string,detail:string):string{return `<div class=\"setting-row quality-row\"><label>${label}<small>${detail}</small></label><div class=\"quality-options toggle-options\"><button data-toggle=\"${name}\" data-value=\"true\">ON</button><button data-toggle=\"${name}\" data-value=\"false\">OFF</button></div></div>`;}\n  private settingValue(name:string,value:number):string{if(name.includes('Volume')||name==='renderScale'||name==='crosshairOpacity')return `${Math.round(value*100)}%`;if(name==='sprintFovBoost')return `+${value}°`;if(name==='fov'||name==='viewmodelFov')return `${value}°`;return `${value.toFixed(1)}×`;}")

# CSS-only UI settings.
css=read('src/ui/style.css')
css+='\n/* v0.2.1 user interface settings */\n.tide-ui{--crosshair-opacity:.8}.crosshair{opacity:var(--crosshair-opacity)}.tide-ui.hide-compass .compass-wrap{display:none}.toggle-options{min-width:112px;justify-content:flex-end}.toggle-options button{min-width:50px;text-align:center}\n'
write('src/ui/style.css',css)

# Tests now validate horizontal 16:9 FPS FOV semantics and configurable sprint boost.
write('tests/camera-projection.test.ts',"""import {describe,it,expect} from 'vitest';
import {PerspectiveCamera} from 'three';
import {FirstPersonProjection,horizontalFov,normalizeFov,worldVerticalFov} from '../src/camera/FirstPersonProjection';

describe('first person camera projection',()=>{
 it('maps the menu value to horizontal FOV at 16:9',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.resize(16/9);
  for(const fov of [70,80,90,100,110,120]){projection.setBaseFov(fov);expect(horizontalFov(camera.fov,16/9)).toBeCloseTo(fov,8);expect(camera.fov).toBeCloseTo(worldVerticalFov(fov),8);}
 });
 it('keeps vertical coverage stable so wider displays gain horizontal view',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.setBaseFov(90);
  const vertical=camera.fov,horizontal=[];for(const aspect of [16/10,16/9,2560/1080]){projection.resize(aspect);expect(camera.fov).toBeCloseTo(vertical,9);horizontal.push(horizontalFov(camera.fov,aspect));}
  expect(horizontal[0]).toBeLessThan(horizontal[1]);expect(horizontal[1]).toBeLessThan(horizontal[2]);expect(horizontal[1]).toBeCloseTo(90,8);
 });
 it('uses a configurable sprint kick without exceeding the maximum',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.resize(16/9);projection.setBaseFov(90);projection.setSprintBoost(5);
  for(let i=0;i<120;i++)projection.update(1/60,true);expect(horizontalFov(camera.fov,16/9)).toBeCloseTo(95,6);
  projection.setBaseFov(118);for(let i=0;i<120;i++)projection.update(1/60,true);expect(horizontalFov(camera.fov,16/9)).toBeCloseTo(120,6);
  expect(normalizeFov(500)).toBe(120);expect(normalizeFov(-4)).toBe(70);expect(normalizeFov(NaN)).toBe(90);
 });
});
""")

# Version/history.
version=read('src/config/version.ts')
version=version.replace("export const GAME_VERSION='0.2.0';","export const GAME_VERSION='0.2.1';").replace("export const GAME_BUILD='EA-02';","export const GAME_BUILD='EA-02.1';")
needle="export const CHANGELOG:ChangeEntry[]=[\n"
entry="  {version:'0.2.1',date:'2026-09-11',title:'Camera & settings patch',changes:[\n    'Fixed FOV to use conventional horizontal degrees at a 16:9 reference instead of feeding horizontal-looking values into Three.js vertical FOV.',\n    'Expanded the useful FOV range to 70°–120° and added a configurable sprint FOV boost.',\n    'Added an independent first-person viewmodel FOV slider for hands and tools.',\n    'Added invert-Y and optional head bob controls.',\n    'Added render scale and dynamic shadow controls for performance tuning.',\n    'Added crosshair opacity and compass visibility options.',\n    'All new settings persist locally and apply immediately.'\n  ]},\n"
if needle not in version: raise SystemExit('version changelog insertion point missing')
write('src/config/version.ts',version.replace(needle,needle+entry,1))

changelog=read('CHANGELOG.md')
entry_md="""## 0.2.1 — 2026-09-11

Camera and settings patch.

- Fixed the world FOV model: the slider is now conventional horizontal FOV at a 16:9 reference, correctly converted to Three.js vertical FOV.
- Expanded world FOV to `70°–120°` and added configurable sprint FOV boost.
- Added separate viewmodel FOV for hands/tools.
- Added invert-Y and optional head bob.
- Added render scale and shadow controls for FPS tuning.
- Added crosshair opacity and compass visibility settings.
- New options persist in local settings and update live.

"""
write('CHANGELOG.md',changelog.replace('# Tideland changelog\n\n','# Tideland changelog\n\n'+entry_md,1))

# Package metadata.
for rel in ['package.json','package-lock.json']:
    data=json.loads(read(rel));data['version']='0.2.1'
    if rel=='package-lock.json' and isinstance(data.get('packages'),dict) and '' in data['packages']: data['packages']['']['version']='0.2.1'
    write(rel,json.dumps(data,indent=2,ensure_ascii=False)+'\n')

print('Tideland v0.2.1 patch applied')
