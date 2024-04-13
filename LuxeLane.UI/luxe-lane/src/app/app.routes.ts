import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { NgModule } from '@angular/core';

export const routes: Routes = [
    {path: 'admin', component: AdminComponent}
];

@NgModule({
    imports : [RouterModule.forRoot(routes)],
    exports : [RouterModule]
})

export class AppRoutingModule {}

