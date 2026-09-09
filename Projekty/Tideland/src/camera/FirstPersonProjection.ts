import {MathUtils,PerspectiveCamera} from 'three';

/** UI degrees are horizontal at 16:9. Keep vertical coverage on wider screens (Hor+). */
export const FOV_REFERENCE_ASPECT=16/9;
export const FOV_MIN=60,FOV_MAX=100,FOV_DEFAULT=90;
export function normalizeFov(value:number):number{return Number.isFinite(value)?MathUtils.clamp(value,FOV_MIN,FOV_MAX):FOV_DEFAULT;}
export function worldVerticalFov(horizontalAt169:number):number{
  return MathUtils.radToDeg(2*Math.atan(Math.tan(MathUtils.degToRad(horizontalAt169)/2)/FOV_REFERENCE_ASPECT));
}
export function horizontalFov(vertical:number,aspect:number):number{
  return MathUtils.radToDeg(2*Math.atan(Math.tan(MathUtils.degToRad(vertical)/2)*aspect));
}
/** Sole writer of the world camera projection. Movement supplies only a sprint state. */
export class FirstPersonProjection {
  private base=FOV_DEFAULT;
  private sprintOffset=0;
  constructor(readonly camera:PerspectiveCamera){this.apply();}
  setBaseFov(value:number){this.base=normalizeFov(value);this.sprintOffset=0;this.apply();}
  resize(aspect:number){this.camera.aspect=Math.max(.1,aspect);this.apply();}
  update(dt:number,sprinting:boolean){
    const target=sprinting?2:0;
    this.sprintOffset=MathUtils.damp(this.sprintOffset,target,10,dt);
    if(Math.abs(this.sprintOffset-target)<.001)this.sprintOffset=target;
    const fov=worldVerticalFov(this.base+this.sprintOffset);
    if(Math.abs(this.camera.fov-fov)>.00001)this.apply();
  }
  private apply(){this.camera.fov=worldVerticalFov(this.base+this.sprintOffset);this.camera.updateProjectionMatrix();}
}
