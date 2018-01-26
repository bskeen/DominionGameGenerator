import { TestBed, inject } from '@angular/core/testing';

import { ExpansionService } from './expansion.service';

describe('ExpansionService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ExpansionService]
    });
  });

  it('should ...', inject([ExpansionService], (service: ExpansionService) => {
    expect(service).toBeTruthy();
  }));
});
