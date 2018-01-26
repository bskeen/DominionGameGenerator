import { Expansion } from './expansion';

export class ParameterCollection {
  expansions: Expansion[];
  prosperityExpandedPercentage: number = 50;
  darkAgesShelterPercentage: number = 50;
  eventFrequency: EventFrequencies = EventFrequencies.Random;
}

export enum EventFrequencies {
  Random = 3,
  Zero = 0,
  One = 1,
  Two = 2
}
