import { Component } from '@angular/core';
import { AuthService } from 'src/app/core/auth/auth.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.sass'],
})
export class AppComponent {
    title = 'frontend';

    constructor(public authService: AuthService) {}

    async signIn(): Promise<void> {
        await this.authService.signInWithGoogle();
        console.log(this.authService.currentUser);
    }

    async logOut(): Promise<void> {
        await this.authService.logout();
        console.log(this.authService.currentUser);
    }
}
