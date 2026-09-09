import type { RecipeDefinition } from '../core/types';

export const RECIPES: Record<string, RecipeDefinition> = {
  storage:{id:'storage',resultItemId:'storage',resultCount:1,ingredients:{wood:160,fiber:20},category:'Building',craftTime:3},
  furnace:{id:'furnace',resultItemId:'furnace',resultCount:1,ingredients:{stone:200,wood:100,fiber:30},category:'Building',craftTime:5},
  campfire:{id:'campfire',resultItemId:'campfire',resultCount:1,ingredients:{stone:35,wood:40},category:'Survival',craftTime:2},
  bedroll:{id:'bedroll',resultItemId:'bedroll',resultCount:1,ingredients:{fiber:80,wood:20},category:'Survival',craftTime:3},
  workbench1:{id:'workbench1',resultItemId:'workbench1',resultCount:1,ingredients:{wood:250,metal:40},category:'Building',craftTime:6},
  workbench2:{id:'workbench2',resultItemId:'workbench2',resultCount:1,ingredients:{wood:350,metal:150},requiredWorkbenchLevel:1,category:'Building',craftTime:8},
  workbench3:{id:'workbench3',resultItemId:'workbench3',resultCount:1,ingredients:{wood:500,metal:350},requiredWorkbenchLevel:2,category:'Building',craftTime:10},

  hatchet: { id: 'hatchet', resultItemId: 'hatchet', resultCount: 1, ingredients: { wood: 90, stone: 60, fiber: 10 }, category: 'Tools', craftTime: 3 },
  pickaxe: { id: 'pickaxe', resultItemId: 'pickaxe', resultCount: 1, ingredients: { wood: 90, stone: 90, fiber: 10 }, category: 'Tools', craftTime: 3 },
  plan: { id: 'plan', resultItemId: 'plan', resultCount: 1, ingredients: { wood: 25, fiber: 10 }, category: 'Building', craftTime: 1.5 },
  bandage: { id: 'bandage', resultItemId: 'bandage', resultCount: 1, ingredients: { fiber: 20 }, category: 'Survival', craftTime: 2 },
  canteen: { id: 'canteen', resultItemId: 'canteen', resultCount: 1, ingredients: { fiber: 35, metal: 8 }, category: 'Survival', craftTime: 3 },
  torch: { id: 'torch', resultItemId: 'torch', resultCount: 1, ingredients: { wood: 30, fiber: 10 }, category: 'Tools', craftTime: 2 },
};
