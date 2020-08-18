import { Retailer } from '../models/retailer';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class RetailerService
{
    url = "http://localhost:59289/api/Retailers";
    constructor(private http: HttpClient)
    {
    }
    public getRetailer():Observable<Retailer[]>
    {
        return this.http.get<Retailer[]>(this.url);
    }
    public postRetailer(retailer:Retailer):Observable<Retailer>
    {
        let httpHeaders = new HttpHeaders()
        .set('Content-Type','application/json');
        let options = {
          headers:httpHeaders
        };
        return this.http.post<Retailer>(this.url,retailer,options);
    }
    public deleteRetailer(id:string):Observable<number>
    {
        let httpHeaders = new HttpHeaders()
        .set('Content-Type','application/json');
        return this.http.delete<number>(this.url+"/"+id);
    }
}