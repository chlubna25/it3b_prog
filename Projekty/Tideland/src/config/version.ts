export const GAME_VERSION='0.2.0';
export const GAME_BUILD='EA-02';
export const GAME_RELEASE_DATE='2026-09-11';

export interface ChangeEntry {version:string;date:string;title:string;changes:string[]}
export const CHANGELOG:ChangeEntry[]=[
  {version:'0.2.0',date:'2026-09-11',title:'Reconciliation update',changes:[
    'Merged the useful unfinished local Codex work into the GitHub build.',
    'Restored direct, clearly visible vertical FOV control from 60° to 100°.',
    'Kept the corrected yaw-based first-person movement so W follows the camera heading.',
    'Improved station placement collision checks against structures, landmarks and resources.',
    'Stations now clear grass beneath their footprint and enforce a safe world station limit.',
    'Improved procedural landmark spacing and safer POI teleport/debug positioning.',
    'Added smoother independent rain, fog and storm transitions plus animated station flames.',
    'Added workbench-specific recipes and cleaner held-item behaviour for station kits.',
    'Added automatic GitHub Pages deployment, visible versioning and this in-game history panel.'
  ]},
  {version:'0.1.0',date:'2026-09-08',title:'Early access foundation',changes:[
    'Procedural island survival loop with gathering, crafting, building and local saves.',
    'Inventory, stations, weather, map/waypoints, structures, tools and first-person viewmodel.',
    'Performance/visual polish, diagnostics and deterministic browser QA tooling.'
  ]}
];
