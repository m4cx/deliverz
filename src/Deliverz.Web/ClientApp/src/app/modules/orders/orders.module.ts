import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrdersRoutingModule } from './orders-routing.module';
import { OrderListPageComponent } from './pages/order-list-page/order-list-page.component';


@NgModule({
  declarations: [OrderListPageComponent],
  imports: [
    CommonModule,
    OrdersRoutingModule,
    HttpClientModule
  ]
})
export class OrdersModule { }
