webpackJsonp([1,4],{

/***/ 151:
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__(23)(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ 152:
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__(23)(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ 153:
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__(23)(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ 154:
/***/ (function(module, exports) {

module.exports = "<header class=\"container\">\r\n  <h1>\r\n    {{title}}\r\n  </h1>\r\n</header>\r\n\r\n<parameters></parameters>\r\n\r\n<game></game>\r\n"

/***/ }),

/***/ 155:
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"game | async; let game\">\r\n\r\n  <div class=\"container\">\r\n    <h4>\r\n      Cards:\r\n    </h4>\r\n    <ol>\r\n      <li *ngFor=\"let card of game.cards\">\r\n        <span class=\"expansion-name\">{{card.expansionName}}:</span> {{card.name}}\r\n        <ul *ngIf=\"card.dependentCards.length > 0\">\r\n          <li *ngFor=\"let dependentCard of card.dependentCards\">\r\n            <span class=\"expansion-name\">{{dependentCard.expansionName}}:</span> {{dependentCard.name}}\r\n          </li>\r\n        </ul>\r\n      </li>\r\n    </ol>\r\n  </div>\r\n\r\n  <div class=\"container\" *ngIf=\"game.events && game.events.length > 0\">\r\n    <h4>\r\n      Events:\r\n    </h4>\r\n    <ul>\r\n      <li *ngFor=\"let event of game.events\">\r\n        <span class=\"expansion-name\">{{event.expansionName}}:</span> {{event.name}}\r\n      </li>\r\n    </ul>\r\n  </div>\r\n\r\n  <div class=\"container\" *ngIf=\"game.landmarks && game.landmarks.length > 0\">\r\n    <h4>\r\n      Landmarks:\r\n    </h4>\r\n    <ul>\r\n      <li *ngFor=\"let landmark of game.landmarks\">\r\n        <span class=\"expansion-name\">{{landmark.expansionName}}:</span> {{landmark.name}}\r\n      </li>\r\n    </ul>\r\n  </div>\r\n\r\n  <div class=\"container\" *ngIf=\"game.includeProsperityExpandedCards\">\r\n    <p>\r\n      The Platinum and Colony cards should be included.\r\n    </p>\r\n  </div>\r\n\r\n  <div class=\"container\" *ngIf=\"game.includeDarkAgesShelters\">\r\n    <p>\r\n      The Shelter cards should be used instead of estates in the initial decks of cards.\r\n    </p>\r\n  </div>\r\n\r\n</div>\r\n"

/***/ }),

/***/ 156:
/***/ (function(module, exports) {

module.exports = "<form [formGroup]=\"parameterForm\" (ngSubmit)=\"submitForm()\" novalidate>\r\n  <div class=\"form-submit-group\">\r\n    <button type=\"submit\" class=\"submit-button\">\r\n      Get Updated Game\r\n    </button>\r\n    <button type=\"button\" class=\"expand-button\" (click)=\"toggleExpand()\">\r\n        <i *ngIf=\"expanded\" class=\"fa fa-caret-up icon-2x\" aria-hidden=\"true\"></i>\r\n        <i *ngIf=\"!expanded\" class=\"fa fa-caret-down icon-2x\" aria-hidden=\"true\"></i>\r\n    </button>\r\n  </div>\r\n\r\n  <div formArrayName=\"expansions\" *ngIf=\"expanded\" class=\"form-control-list\">\r\n    <label *ngFor=\"let expansion of expansionArray.controls; let i=index\" [formGroupName]=\"i\">\r\n      <input formControlName=\"isSelected\" type=\"checkbox\" />\r\n      {{expansion.get('name').value}}\r\n    </label>\r\n  </div>\r\n\r\n  <div class=\"form-control-group\" *ngIf=\"expanded\">\r\n    <label>\r\n      Prosperity Expanded Probability:\r\n      <input formControlName=\"prosperityExpandedPercentage\" type=\"tel\" />\r\n    </label>\r\n  </div>\r\n\r\n  <div class=\"form-control-group\" *ngIf=\"expanded\">\r\n    <label>\r\n      Dark Ages Shelter Probability:\r\n      <input formControlName=\"darkAgesShelterPercentage\" type=\"tel\" />\r\n    </label>\r\n  </div>\r\n\r\n  <div class=\"form-control-group\" *ngIf=\"expanded\">\r\n    <label>\r\n      Event/Landmark Frequency:\r\n      <select formControlName=\"eventFrequency\">\r\n        <option *ngFor=\"let frequency of eventFrequencies | keys\" [value]=\"frequency.key\">\r\n          {{frequency.value}}\r\n        </option>\r\n      </select>\r\n    </label>\r\n  </div>\r\n\r\n</form>\r\n"

/***/ }),

/***/ 194:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(84);


/***/ }),

/***/ 33:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_http__ = __webpack_require__(17);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__ = __webpack_require__(55);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__request_helper_service__ = __webpack_require__(34);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return GameService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var GameService = (function () {
    function GameService(requestHelperService) {
        this.requestHelperService = requestHelperService;
        this._game = new __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__["BehaviorSubject"](null);
        this.game = this._game.asObservable();
    }
    GameService.prototype.ngOnDestroy = function () {
        this._game.complete();
    };
    GameService.prototype.updateGame = function (params) {
        var _this = this;
        var request = new __WEBPACK_IMPORTED_MODULE_1__angular_http__["b" /* Request */]({
            url: route,
            method: __WEBPACK_IMPORTED_MODULE_1__angular_http__["c" /* RequestMethod */].Post,
            body: {
                expansionIDs: params.expansions
                    .filter(function (expansion) { return expansion.isSelected; })
                    .map(function (expansion) { return expansion.expansionID; }),
                prosperityExpandedPercentage: params.prosperityExpandedPercentage,
                darkAgesShelterPercentage: params.darkAgesShelterPercentage,
                eventFrequency: params.eventFrequency
            }
        });
        request = this.requestHelperService.addDefaultHeaders(request);
        var response = this.requestHelperService.performRequest(request);
        response.subscribe(function (response) { return _this._game.next(_this.getGameFromResponse(response)); });
    };
    GameService.prototype.getGameFromResponse = function (response) {
        return response.items[0];
    };
    return GameService;
}());
GameService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_3__request_helper_service__["a" /* RequestHelperService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__request_helper_service__["a" /* RequestHelperService */]) === "function" && _a || Object])
], GameService);

var route = '/api/Games';
var _a;
//# sourceMappingURL=game.service.js.map

/***/ }),

/***/ 34:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_http__ = __webpack_require__(17);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_Subject__ = __webpack_require__(16);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_Subject___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_Subject__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_rxjs_add_operator_map__ = __webpack_require__(73);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3_rxjs_add_operator_map___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_3_rxjs_add_operator_map__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4_rxjs_add_operator_retryWhen__ = __webpack_require__(162);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4_rxjs_add_operator_retryWhen___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_4_rxjs_add_operator_retryWhen__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5_rxjs_add_operator_scan__ = __webpack_require__(163);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5_rxjs_add_operator_scan___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_5_rxjs_add_operator_scan__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6_rxjs_add_operator_delay__ = __webpack_require__(161);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6_rxjs_add_operator_delay___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_6_rxjs_add_operator_delay__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7_rxjs_add_operator_takeUntil__ = __webpack_require__(164);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7_rxjs_add_operator_takeUntil___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_7_rxjs_add_operator_takeUntil__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__authentication_service__ = __webpack_require__(60);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__models_request_error_codes__ = __webpack_require__(94);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return RequestHelperService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};










var RequestHelperService = (function () {
    function RequestHelperService(http, authenticationService) {
        this.http = http;
        this.authenticationService = authenticationService;
        this.ngUnsubscribe = new __WEBPACK_IMPORTED_MODULE_2_rxjs_Subject__["Subject"]();
    }
    RequestHelperService.prototype.ngOnInit = function () {
        var _this = this;
        this.authenticationService.authenticationToken
            .takeUntil(this.ngUnsubscribe)
            .subscribe(function (token) { return _this.token = token; });
    };
    RequestHelperService.prototype.ngOnDestroy = function () {
        this.ngUnsubscribe.next();
        this.ngUnsubscribe.complete();
    };
    RequestHelperService.prototype.addDefaultHeaders = function (request, shouldAuthenticate) {
        if (shouldAuthenticate === void 0) { shouldAuthenticate = false; }
        request.headers.append('Content-Type', 'application/json');
        if (shouldAuthenticate) {
            request.headers.append('Authorization', "Bearer " + this.token);
        }
        return request;
    };
    RequestHelperService.prototype.performRequest = function (request, retryCount, retryDelayMilliseconds) {
        var _this = this;
        if (retryCount === void 0) { retryCount = 3; }
        if (retryDelayMilliseconds === void 0) { retryDelayMilliseconds = 500; }
        return this.http.request(request)
            .map(function (response) { return response.json(); })
            .retryWhen(function (error) {
            if (error instanceof __WEBPACK_IMPORTED_MODULE_1__angular_http__["d" /* Response */]) {
                if (!retryErrorCodes.includes(error.status)) {
                    throw error;
                }
            }
            return _this.retryLogic(error, retryCount, retryDelayMilliseconds);
        });
    };
    RequestHelperService.prototype.retryLogic = function (error, retryCount, retryDelayMilliseconds) {
        return error.scan(function (errorCount, err) {
            if (errorCount >= retryCount) {
                throw err;
            }
            return errorCount + 1;
        }, 0).delay(retryDelayMilliseconds);
    };
    return RequestHelperService;
}());
RequestHelperService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_http__["e" /* Http */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_http__["e" /* Http */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_8__authentication_service__["a" /* AuthenticationService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_8__authentication_service__["a" /* AuthenticationService */]) === "function" && _b || Object])
], RequestHelperService);

var retryErrorCodes = [
    __WEBPACK_IMPORTED_MODULE_9__models_request_error_codes__["a" /* RequestErrorCodes */].BadRequest
];
var _a, _b;
//# sourceMappingURL=request-helper.service.js.map

/***/ }),

/***/ 60:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_http__ = __webpack_require__(17);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__ = __webpack_require__(55);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AuthenticationService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AuthenticationService = (function () {
    function AuthenticationService() {
        this._authenticationToken = new __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__["BehaviorSubject"](JSON.parse(localStorage.getItem('auth_token')));
        this.authenticationToken = this._authenticationToken.asObservable().map(function (token) { return token.token; });
    }
    AuthenticationService.prototype.ngOnDestroy = function () {
        this._authenticationToken.complete();
    };
    AuthenticationService.prototype.requestNewToken = function (username, password, requestHelperService) {
        var _this = this;
        var request = new __WEBPACK_IMPORTED_MODULE_1__angular_http__["b" /* Request */]({
            url: '/token',
            method: __WEBPACK_IMPORTED_MODULE_1__angular_http__["c" /* RequestMethod */].Post,
            body: {
                username: username,
                password: password
            }
        });
        request = requestHelperService.addDefaultHeaders(request, false);
        var result = requestHelperService.performRequest(request);
        result.subscribe(function (authToken) {
            localStorage.setItem('auth_token', JSON.stringify(authToken));
            _this._authenticationToken.next(authToken);
        });
    };
    return AuthenticationService;
}());
AuthenticationService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [])
], AuthenticationService);

//# sourceMappingURL=authentication.service.js.map

/***/ }),

/***/ 83:
/***/ (function(module, exports) {

function webpackEmptyContext(req) {
	throw new Error("Cannot find module '" + req + "'.");
}
webpackEmptyContext.keys = function() { return []; };
webpackEmptyContext.resolve = webpackEmptyContext;
module.exports = webpackEmptyContext;
webpackEmptyContext.id = 83;


/***/ }),

/***/ 84:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__(88);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__(89);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__(97);




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["a" /* enableProdMode */])();
}
__webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */]);
//# sourceMappingURL=main.js.map

/***/ }),

/***/ 89:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__ = __webpack_require__(25);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_forms__ = __webpack_require__(59);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__angular_http__ = __webpack_require__(17);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__components_app_component__ = __webpack_require__(90);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__services_authentication_service__ = __webpack_require__(60);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__services_request_helper_service__ = __webpack_require__(34);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__components_game_game_component__ = __webpack_require__(91);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__components_parameters_parameters_component__ = __webpack_require__(92);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__services_game_service__ = __webpack_require__(33);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10__pipes_keys_pipe__ = __webpack_require__(95);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};











var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_core__["b" /* NgModule */])({
        declarations: [
            __WEBPACK_IMPORTED_MODULE_4__components_app_component__["a" /* AppComponent */],
            __WEBPACK_IMPORTED_MODULE_7__components_game_game_component__["a" /* GameComponent */],
            __WEBPACK_IMPORTED_MODULE_8__components_parameters_parameters_component__["a" /* ParametersComponent */],
            __WEBPACK_IMPORTED_MODULE_10__pipes_keys_pipe__["a" /* KeysPipe */]
        ],
        imports: [
            __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__["a" /* BrowserModule */],
            __WEBPACK_IMPORTED_MODULE_3__angular_http__["a" /* HttpModule */],
            __WEBPACK_IMPORTED_MODULE_2__angular_forms__["a" /* ReactiveFormsModule */]
        ],
        providers: [
            __WEBPACK_IMPORTED_MODULE_5__services_authentication_service__["a" /* AuthenticationService */],
            __WEBPACK_IMPORTED_MODULE_6__services_request_helper_service__["a" /* RequestHelperService */],
            __WEBPACK_IMPORTED_MODULE_9__services_game_service__["a" /* GameService */]
        ],
        bootstrap: [__WEBPACK_IMPORTED_MODULE_4__components_app_component__["a" /* AppComponent */]]
    })
], AppModule);

//# sourceMappingURL=app.module.js.map

/***/ }),

/***/ 90:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var AppComponent = (function () {
    function AppComponent() {
        this.title = 'Dominion Card Chooser';
    }
    AppComponent.prototype.ngOnInit = function () {
    };
    return AppComponent;
}());
AppComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_4" /* Component */])({
        selector: 'app-root',
        template: __webpack_require__(154),
        styles: [__webpack_require__(151)]
    }),
    __metadata("design:paramtypes", [])
], AppComponent);

//# sourceMappingURL=app.component.js.map

/***/ }),

/***/ 91:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_map__ = __webpack_require__(73);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_map___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_rxjs_add_operator_map__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__services_game_service__ = __webpack_require__(33);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return GameComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var GameComponent = (function () {
    function GameComponent(gameService) {
        this.gameService = gameService;
    }
    GameComponent.prototype.ngOnInit = function () {
        this.game = this.gameService.game;
    };
    return GameComponent;
}());
GameComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_4" /* Component */])({
        selector: 'game',
        template: __webpack_require__(155),
        styles: [__webpack_require__(152)]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__services_game_service__["a" /* GameService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__services_game_service__["a" /* GameService */]) === "function" && _a || Object])
], GameComponent);

var _a;
//# sourceMappingURL=game.component.js.map

/***/ }),

/***/ 92:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_forms__ = __webpack_require__(59);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__services_expansion_service__ = __webpack_require__(96);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__services_game_service__ = __webpack_require__(33);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__models_parameter_collection__ = __webpack_require__(93);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ParametersComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};





var ParametersComponent = (function () {
    function ParametersComponent(fb, expansionService, gameService) {
        this.fb = fb;
        this.expansionService = expansionService;
        this.gameService = gameService;
        this.expansionArray = this.fb.array([]);
        this.eventFrequencies = __WEBPACK_IMPORTED_MODULE_4__models_parameter_collection__["a" /* EventFrequencies */];
        this.expanded = false;
        this.createForm();
    }
    ParametersComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.expansionService.expansions.subscribe(function (expansions) { return _this.setExpansions(expansions); });
        this.expansionService.updateExpansions();
    };
    ParametersComponent.prototype.setExpansions = function (expansions) {
        var _this = this;
        var expansionFormGroups = expansions.map(function (expansion) { return _this.fb.group(expansion); });
        this.expansionArray = this.fb.array(expansionFormGroups);
        this.parameterForm.setControl('expansions', this.expansionArray);
    };
    ParametersComponent.prototype.createForm = function () {
        this.parameterForm = this.fb.group({
            expansions: this.fb.array([]),
            prosperityExpandedPercentage: 50,
            darkAgesShelterPercentage: 50,
            eventFrequency: __WEBPACK_IMPORTED_MODULE_4__models_parameter_collection__["a" /* EventFrequencies */].Random
        });
    };
    ParametersComponent.prototype.submitForm = function () {
        var parameterCollection = this.prepareParameterCollection();
        this.gameService.updateGame(parameterCollection);
    };
    ParametersComponent.prototype.prepareParameterCollection = function () {
        var formModel = this.parameterForm.value;
        var expansionDeepCopy = formModel.expansions.map(function (expansion) { return Object.assign({}, expansion); });
        var preparedParameters = {
            expansions: expansionDeepCopy,
            prosperityExpandedPercentage: Number(formModel.prosperityExpandedPercentage),
            darkAgesShelterPercentage: Number(formModel.darkAgesShelterPercentage),
            eventFrequency: formModel.eventFrequency
        };
        return preparedParameters;
    };
    ParametersComponent.prototype.toggleExpand = function () {
        this.expanded = !this.expanded;
    };
    return ParametersComponent;
}());
ParametersComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_4" /* Component */])({
        selector: 'parameters',
        template: __webpack_require__(156),
        styles: [__webpack_require__(153)],
        providers: [__WEBPACK_IMPORTED_MODULE_2__services_expansion_service__["a" /* ExpansionService */]]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_forms__["b" /* FormBuilder */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_forms__["b" /* FormBuilder */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_2__services_expansion_service__["a" /* ExpansionService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__services_expansion_service__["a" /* ExpansionService */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_3__services_game_service__["a" /* GameService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__services_game_service__["a" /* GameService */]) === "function" && _c || Object])
], ParametersComponent);

var _a, _b, _c;
//# sourceMappingURL=parameters.component.js.map

/***/ }),

/***/ 93:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* unused harmony export ParameterCollection */
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return EventFrequencies; });
var ParameterCollection = (function () {
    function ParameterCollection() {
        this.prosperityExpandedPercentage = 50;
        this.darkAgesShelterPercentage = 50;
        this.eventFrequency = EventFrequencies.Random;
    }
    return ParameterCollection;
}());

var EventFrequencies;
(function (EventFrequencies) {
    EventFrequencies[EventFrequencies["Random"] = 3] = "Random";
    EventFrequencies[EventFrequencies["Zero"] = 0] = "Zero";
    EventFrequencies[EventFrequencies["One"] = 1] = "One";
    EventFrequencies[EventFrequencies["Two"] = 2] = "Two";
})(EventFrequencies || (EventFrequencies = {}));
//# sourceMappingURL=parameter-collection.js.map

/***/ }),

/***/ 94:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return RequestErrorCodes; });
var RequestErrorCodes;
(function (RequestErrorCodes) {
    RequestErrorCodes[RequestErrorCodes["BadRequest"] = 400] = "BadRequest";
    RequestErrorCodes[RequestErrorCodes["Unauthorized"] = 401] = "Unauthorized";
})(RequestErrorCodes || (RequestErrorCodes = {}));
//# sourceMappingURL=request-error-codes.js.map

/***/ }),

/***/ 95:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return KeysPipe; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var KeysPipe = (function () {
    function KeysPipe() {
    }
    KeysPipe.prototype.transform = function (value, args) {
        var keys = [];
        for (var enumMember in value) {
            if (!isNaN(parseInt(enumMember, 10))) {
                keys.push({ key: enumMember, value: value[enumMember] });
            }
        }
        return keys;
    };
    return KeysPipe;
}());
KeysPipe = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Y" /* Pipe */])({
        name: 'keys'
    })
], KeysPipe);

//# sourceMappingURL=keys.pipe.js.map

/***/ }),

/***/ 96:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(3);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_http__ = __webpack_require__(17);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__ = __webpack_require__(55);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__request_helper_service__ = __webpack_require__(34);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ExpansionService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var ExpansionService = (function () {
    function ExpansionService(requestHelperService) {
        this.requestHelperService = requestHelperService;
        this._expansions = new __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__["BehaviorSubject"]([]);
        this.expansions = this._expansions.asObservable();
    }
    ExpansionService.prototype.ngOnInit = function () {
        this.updateExpansions();
    };
    ExpansionService.prototype.ngOnDestroy = function () {
        this._expansions.complete();
    };
    ExpansionService.prototype.updateExpansions = function () {
        var _this = this;
        var request = new __WEBPACK_IMPORTED_MODULE_1__angular_http__["b" /* Request */]({
            url: route,
            method: __WEBPACK_IMPORTED_MODULE_1__angular_http__["c" /* RequestMethod */].Get
        });
        request = this.requestHelperService.addDefaultHeaders(request, false);
        var result = this.requestHelperService.performRequest(request);
        result.subscribe(function (response) { return _this._expansions.next(response.items); });
    };
    return ExpansionService;
}());
ExpansionService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_3__request_helper_service__["a" /* RequestHelperService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__request_helper_service__["a" /* RequestHelperService */]) === "function" && _a || Object])
], ExpansionService);

var route = '/api/Expansions';
var _a;
//# sourceMappingURL=expansion.service.js.map

/***/ }),

/***/ 97:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
// The file contents for the current environment will overwrite these during build.
var environment = {
    production: false
};
//# sourceMappingURL=environment.js.map

/***/ })

},[194]);
//# sourceMappingURL=main.bundle.js.map