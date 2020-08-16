import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { authGuardGuard } from './gaurd/auth-guard.guard';


const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
