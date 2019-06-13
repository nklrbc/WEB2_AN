import { TestBed } from '@angular/core/testing';

import { DodavanjeLinijeService } from './dodavanje-linije.service';

describe('DodavanjeKarteService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DodavanjeLinijeService = TestBed.get(DodavanjeLinijeService);
    expect(service).toBeTruthy();
  });
});
