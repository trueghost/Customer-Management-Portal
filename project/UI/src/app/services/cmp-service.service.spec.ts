import { TestBed } from '@angular/core/testing';

import { CmpServiceService } from './cmp-service.service';

describe('CmpServiceService', () => {
  let service: CmpServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CmpServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
