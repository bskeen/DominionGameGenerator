import { Expansion } from './expansion';

export class Card {
    name: string;
    expansionName: string;
    types: string[];
    categories: string[];
    dependentCards: Card[];
}
