import { Product } from '../models/product'
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class ProductService
{
    constructor(private http: HttpClient)
    {
    }
    public getProducts()
    {
        return this.http.get("http://localhost:59289/api/ProductDetails");
    }
    public postProduct(product:Product) //insert
    {
        return this.http.post("http://localhost:59289/api/ProductDetails",product);
    }
    public putProduct(id:number, prod:Product) //edit
    {
        return this.http.put("http://localhost:59289/api/ProductDetails"+id,prod);
    }
    public delProduct(id:number)
    {
        return this.http.delete("http://localhost:59289/api/ProductDetails"+id);
    }
}