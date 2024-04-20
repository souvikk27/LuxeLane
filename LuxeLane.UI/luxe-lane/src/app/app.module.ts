import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NbSidebarModule } from '@nebular/theme';

@NgModule({
  imports: [
    CommonModule,
    NbSidebarModule.forRoot(),
  ],
})
export class AppModule { }