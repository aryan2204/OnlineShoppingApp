import {RetProduct } from '../model/retailerProduct';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class RetProductService
{
    constructor(private http: HttpClient)
    {
    }
    public AddProduct(product:RetProduct) //insert
    {
        return this.http.post("http://localhost:59289/api/ProductDetails",product);
    }
}