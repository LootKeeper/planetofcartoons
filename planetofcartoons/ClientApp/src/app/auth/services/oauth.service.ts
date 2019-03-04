import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';

import { RoleType } from '../model/roleType';
import { User } from '../model/user';
import { LoginModel } from '../model/loginModel';
import { Local } from 'protractor/built/driverProviders';
import { Observable } from 'rxjs';
import { TokenReponse } from '../model/tokenResponse';
import { ClaimsIndentity } from '../model/claimsIdentity';


@Injectable()
export class OAuthService {

    private _http: HttpClient;
    private _jwtService: JwtHelperService;

    private _oauthApiUrl = 'api/Auth/';    
    private _loginUrl = this._oauthApiUrl + 'login';

    private _tokenKey: string = 'access_token';

    constructor(http: HttpClient, jwtService: JwtHelperService) 
    {
        this._http = http;
        this._jwtService = jwtService;
    }

    public isUserAuthorized(): boolean {
        return this.isTokenExist();
    }

    public isUserInRole(roleType: RoleType): boolean {
        if (roleType) {
            const userRole = this.readToken()[ClaimsIndentity.DefaultRoleClaimType] as RoleType;
            return roleType === userRole;
        } 

        return false;        
    }

    public isUserInAnyRole(roleTypes: RoleType[]): boolean {
        return roleTypes.some(roleType => this.isUserInRole(roleType));
    }

    public login(loginModel: LoginModel): Observable<TokenReponse>{
        return this._http.post<TokenReponse>(this._loginUrl, loginModel);
    }

    public writeToken(token: string) {
        localStorage.setItem(this._tokenKey, token);
    }

    private isTokenExist(): boolean {
        return this._jwtService.tokenGetter() !== null;
    }

    private readToken(): any {
        return this._jwtService.decodeToken(this._jwtService.tokenGetter());
    }
}
