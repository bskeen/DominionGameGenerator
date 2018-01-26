import { Injectable, OnInit, OnDestroy } from '@angular/core';
import { Request, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

import { Expansion } from '../models/expansion';
import { ServerResponse } from '../models/server-response';
import { RequestHelperService } from './request-helper.service';

@Injectable()
export class ExpansionService implements OnInit, OnDestroy {

  private _expansions: BehaviorSubject<Expansion[]> = new BehaviorSubject<Expansion[]>([]);
  public readonly expansions: Observable<Expansion[]> = this._expansions.asObservable();

  constructor(private requestHelperService: RequestHelperService)
  {
  }

  ngOnInit() {
    this.updateExpansions();
  }

  ngOnDestroy() {
    this._expansions.complete();
  }

  updateExpansions() {
    let request = new Request({
      url: route,
      method: RequestMethod.Get
    });

    request = this.requestHelperService.addDefaultHeaders(request, false);

    let result = this.requestHelperService.performRequest<ServerResponse<Expansion>>(request);

    result.subscribe(response => this._expansions.next(response.items));
  }

}

const route = '/api/Expansions';
