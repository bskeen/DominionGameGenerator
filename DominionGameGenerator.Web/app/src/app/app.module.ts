import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './components/app.component';
import { AuthenticationService } from './services/authentication.service';
import { RequestHelperService } from './services/request-helper.service';
import { GameComponent } from './components/game/game.component';
import { ParametersComponent } from './components/parameters/parameters.component';
import { GameService } from './services/game.service';
import { KeysPipe } from './pipes/keys.pipe';

@NgModule({
  declarations: [
    AppComponent,
    GameComponent,
    ParametersComponent,
    KeysPipe
  ],
  imports: [
    BrowserModule,
    HttpModule,
    ReactiveFormsModule
  ],
  providers: [
    AuthenticationService,
    RequestHelperService,
    GameService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
