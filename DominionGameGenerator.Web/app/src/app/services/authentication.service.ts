import { Injectable, OnDestroy } from '@angular/core';
import { Request, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

import { AuthenticationToken } from '../models/authentication-token';
import { RequestHelperService } from './request-helper.service';

@Injectable()
export class AuthenticationService implements OnDestroy {

  private _authenticationToken: BehaviorSubject<AuthenticationToken> = new BehaviorSubject(JSON.parse(localStorage.getItem('auth_token')));
  public readonly authenticationToken: Observable<string> = this._authenticationToken.asObservable().map(token => token.token);
  private authToken: string;

  constructor()
  {
  }

  ngOnDestroy() {
    this._authenticationToken.complete();
  }

  requestNewToken(username: string, password: string, requestHelperService: RequestHelperService) {
    let request = new Request({
      url: '/token',
      method: RequestMethod.Post,
      body: {
        username: username,
        password: password
      }
    });

    request = requestHelperService.addDefaultHeaders(request, false);

    let result = requestHelperService.performRequest<AuthenticationToken>(request);

    result.subscribe(authToken => {
      localStorage.setItem('auth_token', JSON.stringify(authToken));
      this._authenticationToken.next(authToken);
    });
  }

}
