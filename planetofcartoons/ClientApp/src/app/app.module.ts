import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { TokenGuard } from './auth/guard/token.guard';
import { AuthModule } from './auth/auth.module';

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
        AppComponent
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
