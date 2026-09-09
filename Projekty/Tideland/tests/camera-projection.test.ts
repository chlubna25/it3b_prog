import {describe,it,expect} from 'vitest';
import {PerspectiveCamera} from 'three';
import {FirstPersonProjection,worldVerticalFov,horizontalFov,normalizeFov} from '../src/camera/FirstPersonProjection';
describe('first person camera projection',()=>{
 it('maps the documented horizontal slider to a genuine vertical projection',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.resize(16/9);
  let previousScale=Infinity;
  for(const fov of [60,70,75,80,90,100]){projection.setBaseFov(fov);expect(horizontalFov(camera.fov,camera.aspect)).toBeCloseTo(fov,9);expect(camera.projectionMatrix.elements[5]).toBeCloseTo(1/Math.tan(camera.fov*Math.PI/360),9);expect(camera.projectionMatrix.elements[5]).toBeLessThan(previousScale);previousScale=camera.projectionMatrix.elements[5];}
 });
 it('keeps vertical coverage and adds side coverage on ultrawide, without changing the base setting',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.setBaseFov(90);
  const horizontal=[];for(const aspect of [16/10,16/9,2560/1080]){projection.resize(aspect);expect(camera.fov).toBeCloseTo(worldVerticalFov(90),9);horizontal.push(horizontalFov(camera.fov,aspect));}
  expect(horizontal[0]).toBeLessThan(horizontal[1]);expect(horizontal[1]).toBeLessThan(horizontal[2]);expect(horizontal[2]).toBeLessThan(110);
 });
 it('interpolates only a small sprint offset and restores the selected baseline',()=>{
  const camera=new PerspectiveCamera(),projection=new FirstPersonProjection(camera);projection.setBaseFov(75);
  projection.update(1/60,true);expect(camera.fov).toBeGreaterThan(worldVerticalFov(75));expect(camera.fov).toBeLessThan(worldVerticalFov(77));
  for(let i=0;i<120;i++)projection.update(1/60,true);expect(camera.fov).toBeCloseTo(worldVerticalFov(77),8);
  projection.resize(16/10);expect(camera.fov).toBeCloseTo(worldVerticalFov(77),8);
  projection.setBaseFov(100);expect(camera.fov).toBeCloseTo(worldVerticalFov(100),8);
  for(let i=0;i<120;i++)projection.update(1/60,false);expect(camera.fov).toBeCloseTo(worldVerticalFov(100),8);
  expect(normalizeFov(500)).toBe(100);expect(normalizeFov(-4)).toBe(60);expect(normalizeFov(NaN)).toBe(90);
 });
});
