import { Component } from '@angular/core';
import { OAuthService } from './auth/services/oauth.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
})
export class AppComponent {
    title = 'ClientApp';
}
