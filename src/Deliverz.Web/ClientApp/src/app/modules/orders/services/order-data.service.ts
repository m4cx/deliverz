import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReplaySubject } from 'rxjs';
import { take } from 'rxjs/operators';
import { Order } from '../models/order';

@Injectable({
  providedIn: 'root'
})
export class OrderDataService {

  private ordersSubject = new ReplaySubject<Order[]>();

  constructor(private http: HttpClient) {
    this.load();
  }

  public get orders$() {
    return this.ordersSubject.asObservable();
  }

  public async load() {
    this.http.get<Order[]>('api/orders')
      .pipe(take(1))
      .toPromise()
      .then(x => this.ordersSubject.next(x));
  }
}
