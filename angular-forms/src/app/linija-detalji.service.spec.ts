import { TestBed } from '@angular/core/testing';

import { LinijaDetaljiService } from './linija-detalji.service';

describe('LinijaDetaljiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LinijaDetaljiService = TestBed.get(LinijaDetaljiService);
    expect(service).toBeTruthy();
  });
});
