export class Input {
  readonly keys = new Set<string>();
  locked = false;
  onLook: (x:number,y:number)=>void = ()=>{};
  onKey: (code:string)=>void = ()=>{};
  onClick: (button:number)=>void = ()=>{};
  onLockChange: (locked:boolean)=>void = ()=>{};
  onWheel:(direction:number)=>void=()=>{};
  private handlers: Array<()=>void> = [];
  constructor(private canvas:HTMLCanvasElement) {
    const bind = (target:EventTarget,type:string,fn:EventListener) => {target.addEventListener(type,fn);this.handlers.push(()=>target.removeEventListener(type,fn));};
    bind(window,'keydown',((e:KeyboardEvent)=>{
      const target=e.target;
      if (target instanceof HTMLElement && target.matches('input,select,textarea')) return;
      if (['Tab','Space','ArrowUp','ArrowDown','F3'].includes(e.code)) e.preventDefault();
      this.keys.add(e.code); if (!e.repeat) this.onKey(e.code);
    }) as EventListener);
    bind(window,'keyup',((e:KeyboardEvent)=>{this.keys.delete(e.code);}) as EventListener);
    bind(document,'mousemove',((e:MouseEvent)=>{if(this.locked)this.onLook(e.movementX,e.movementY);}) as EventListener);
    bind(document,'pointerlockchange',()=>{this.locked=document.pointerLockElement===canvas;this.keys.clear();this.onLockChange(this.locked);});
    bind(canvas,'mousedown',((e:MouseEvent)=>{e.preventDefault();this.onClick(e.button);}) as EventListener);
    bind(canvas,'contextmenu',(e)=>e.preventDefault());
    bind(canvas,'wheel',((e:WheelEvent)=>{e.preventDefault();this.onWheel(Math.sign(e.deltaY));}) as EventListener);
    bind(window,'blur',()=>{this.keys.clear();this.release();});
  }
  down(...keys:string[]) {return keys.some(k=>this.keys.has(k));}
  async lock() {try {await this.canvas.requestPointerLock();}catch { /* Browser may reject while another lock request is leaving. A click retries. */ }}
  release(){if(document.pointerLockElement)document.exitPointerLock();this.keys.clear();}
  dispose(){this.handlers.forEach(fn=>fn());}
}
