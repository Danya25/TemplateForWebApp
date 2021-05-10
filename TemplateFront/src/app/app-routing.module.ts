import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {UnauthGuard} from './services/guards/unauth.guard';

const routes: Routes = [
  {path: 'auth', canActivate: [UnauthGuard], loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule)},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
