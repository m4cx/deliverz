import { OrderDataService } from './../../services/order-data.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-order-list-page',
  templateUrl: './order-list-page.component.html',
  styleUrls: ['./order-list-page.component.css']
})
export class OrderListPageComponent implements OnInit {

  public orders$ = this.orderData.orders$;

  constructor(private orderData: OrderDataService) { }

  ngOnInit(): void {
  }

}
