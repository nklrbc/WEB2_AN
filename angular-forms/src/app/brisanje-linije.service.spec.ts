import { TestBed } from '@angular/core/testing';

import { BrisanjeLinijeService } from './brisanje-linije.service';

describe('BrisanjeLinijeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BrisanjeLinijeService = TestBed.get(BrisanjeLinijeService);
    expect(service).toBeTruthy();
  });
});
