import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './routing/app-routing.module';
import { AppComponent } from './app.component';
import { ScenesModule } from './scenes/scenes.module';
import { SharedModule } from './shared/shared.module';
import { AuthService } from './core/auth/auth.service';
import { CoreModule } from './core/core.module';
import { TokenInterceptorService } from './core/auth/token-interceptor.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

@NgModule({
    declarations: [AppComponent],
    imports: [BrowserModule, AppRoutingModule, ScenesModule, SharedModule, CoreModule, HttpClientModule],
    providers: [
        AuthService,
        {
            provide: HTTP_INTERCEPTORS,
            useClass: TokenInterceptorService,
            multi: true,
        },
    ],
    bootstrap: [AppComponent],
})
export class AppModule {}
