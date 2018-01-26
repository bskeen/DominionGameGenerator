import { Injectable, OnInit, OnDestroy } from '@angular/core';
import { Request, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

import { Game } from '../models/game';
import { ParameterCollection } from '../models/parameter-collection';
import { ServerResponse } from '../models/server-response';
import { RequestHelperService } from './request-helper.service';

@Injectable()
export class GameService implements OnDestroy {

  private _game: BehaviorSubject<Game> = new BehaviorSubject<Game>(null);
  public readonly game: Observable<Game> = this._game.asObservable();

  constructor(private requestHelperService: RequestHelperService)
  {
  }

  ngOnDestroy() {
    this._game.complete();
  }

  updateGame(params: ParameterCollection) {
    let request = new Request({
      url: route,
      method: RequestMethod.Post,
      body: {
        expansionIDs: params.expansions
                            .filter(expansion => expansion.isSelected)
                            .map(expansion => expansion.expansionID),
        prosperityExpandedPercentage: params.prosperityExpandedPercentage,
        darkAgesShelterPercentage: params.darkAgesShelterPercentage,
        eventFrequency: params.eventFrequency
      }
    });

    request = this.requestHelperService.addDefaultHeaders(request);

    let response = this.requestHelperService.performRequest<ServerResponse<Game>>(request);

    response.subscribe(response => this._game.next(this.getGameFromResponse(response)));
  }

  private getGameFromResponse(response: ServerResponse<Game>): Game {
    return response.items[0];
  }

}

const route = '/api/Games';
