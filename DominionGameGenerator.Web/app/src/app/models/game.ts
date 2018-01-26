import { Card } from './card';

export class Game {
    cards: Card[];
    events: Card[];
    landmarks: Card[];
    includeProsperityExpandedCards: boolean = false;
    includeDarkAgesShelters: boolean = false;
}
