import { TestBed } from '@angular/core/testing';

import { OrderDataService } from './order-data.service';
import { HttpClient } from '@angular/common/http';
import { of } from 'rxjs';

describe('OrderDataService', () => {
  let service: OrderDataService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: HttpClient, useFactory: () => {
            return { get: () => of([]) };
          }
        }
      ]
    });
    service = TestBed.inject(OrderDataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
