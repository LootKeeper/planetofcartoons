import { TestBed } from '@angular/core/testing';

import { OAuthService } from './oauth.service';

describe('OauthService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: OAuthService = TestBed.get(OAuthService);
    expect(service).toBeTruthy();
  });
});
