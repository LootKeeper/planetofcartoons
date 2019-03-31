import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { TokenGuard } from './auth/guard/token.guard';
import { AuthModule } from './auth/auth.module';
import { BodyComponent } from './body/body/body.component';
import { MainComponent } from './main/main.component';
import { HeaderComponent } from './main/header/header.component';
import { MediaComponent } from './media/media.component';

const routes: Routes = [
    {
        path: '',
        component: AppComponent,
        canActivate: [TokenGuard],
        data:[{roles: 'User'}]
    }
]

@NgModule({
    declarations: [
        AppComponent,
        BodyComponent,
        MainComponent,
        HeaderComponent,
        MediaComponent
    ],
    imports: [
        BrowserModule,
        HttpClientModule,        
        RouterModule.forRoot(routes),
        AuthModule
    ],
    providers: [TokenGuard],
    bootstrap: [AppComponent]
})
export class AppModule { }
