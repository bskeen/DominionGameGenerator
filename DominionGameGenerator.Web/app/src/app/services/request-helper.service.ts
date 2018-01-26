import { Injectable, OnInit, OnDestroy } from '@angular/core';
import { Http, Request, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/retryWhen';
import 'rxjs/add/operator/scan';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/takeUntil';

import { AuthenticationService } from './authentication.service';
import { ServerResponse } from '../models/server-response';
import { RequestErrorCodes } from '../models/request-error-codes';

@Injectable()
export class RequestHelperService implements OnInit, OnDestroy {

  private token: string;
  private ngUnsubscribe: Subject<any> = new Subject<any>();

  constructor(private http: Http, private authenticationService: AuthenticationService) { }

  ngOnInit() {
    this.authenticationService.authenticationToken
                              .takeUntil(this.ngUnsubscribe)
                              .subscribe(token => this.token = token);
  }

  ngOnDestroy() {
    this.ngUnsubscribe.next();
    this.ngUnsubscribe.complete();
  }

  addDefaultHeaders(request: Request, shouldAuthenticate: boolean = false): Request {
    request.headers.append('Content-Type', 'application/json');

    if (shouldAuthenticate) {
      request.headers.append('Authorization', `Bearer ${this.token}`);
    }

    return request;
  }

  performRequest<T>(request: Request, retryCount: number = 3, retryDelayMilliseconds: number = 500) : Observable<T> {
    return this.http.request(request)
                    .map(response => response.json())
                    .retryWhen(error => {
                      if (error instanceof Response) {
                        if (!retryErrorCodes.includes(error.status)) {
                          throw error;
                        }
                      }

                      return this.retryLogic(error, retryCount, retryDelayMilliseconds);
                    });
  }


  private retryLogic(error: Observable<any>, retryCount: number, retryDelayMilliseconds: number) : Observable<any> {
    return error.scan((errorCount, err) => {
      if (errorCount >= retryCount) {
        throw err;
      }
      return errorCount + 1;
    }, 0).delay(retryDelayMilliseconds);
  }

}

const retryErrorCodes = [
  RequestErrorCodes.BadRequest
];
