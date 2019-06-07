import { TestBed } from '@angular/core/testing';

import { KupovinaService } from './kupovina.service';

describe('KupovinaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: KupovinaService = TestBed.get(KupovinaService);
    expect(service).toBeTruthy();
  });
});
