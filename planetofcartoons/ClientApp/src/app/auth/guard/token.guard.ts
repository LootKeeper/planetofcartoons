import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, CanActivate } from '@angular/router';
import { Observable } from 'rxjs';
import { OAuthService } from '../services/oauth.service';
import { RoleType, convertToRoles } from '../model/roleType';

@Injectable()
export class TokenGuard implements CanActivate {

    private _oauthService: OAuthService;

    constructor(oauthService: OAuthService) {        
        this._oauthService = oauthService;
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        debugger;
        const roles = this.extractRoleTypes(route);
        if (this._oauthService.isUserAuthorized() && this._oauthService.isUserInAnyRole(roles)) {
            return true;
        }

        return false;
    }

    private extractRoleTypes(route: ActivatedRouteSnapshot): RoleType[] {
        let data = route.data as any[];
        let roles = null;
        for (var i in data) {
            if (data[i].roles) {
                roles = data[i].roles;
                break;
            }
        }
        return convertToRoles(roles);
    }
}
