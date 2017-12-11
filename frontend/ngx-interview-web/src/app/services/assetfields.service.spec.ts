import { TestBed, inject } from '@angular/core/testing';

import { AssetFieldsService } from './assetfields.service';

describe('AssetfieldsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AssetFieldsService]
    });
  });

  it('should be created', inject([AssetFieldsService], (service: AssetFieldsService) => {
    expect(service).toBeTruthy();
  }));
});
