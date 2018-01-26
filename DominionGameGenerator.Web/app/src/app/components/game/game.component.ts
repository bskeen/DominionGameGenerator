import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/map';

import { GameService } from '../../services/game.service';
import { Game } from '../../models/game';
import { Card } from '../../models/card';

@Component({
  selector: 'game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss']
})
export class GameComponent implements OnInit {

  game: Observable<Game>;

  constructor(private gameService: GameService) { }

  ngOnInit() {
    this.game = this.gameService.game;
  }

}
