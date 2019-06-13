import { TestBed } from '@angular/core/testing';

import { MenjajCenovnikService } from './menjaj-cenovnik.service';

describe('MenjajCenovnikService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MenjajCenovnikService = TestBed.get(MenjajCenovnikService);
    expect(service).toBeTruthy();
  });
});
