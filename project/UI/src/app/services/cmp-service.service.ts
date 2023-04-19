import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CmpServiceService {

  readonly CMP_APIUrl = "https://localhost:7122/api";

  constructor(private http:HttpClient) {}
    
    getCustomerDetails():Observable<any[]> {
      return this.http.get<any>(this.CMP_APIUrl + '/Customers');
    }
   
    addCustomers(data:any) {
      // debugger;
      return this.http.post(this.CMP_APIUrl + '/Customers', data);
    }

    updateCustomers(id:number|string, data:any) {
      return this.http.put(this.CMP_APIUrl + `/Customers/${id}`, data);
    }
    
    deleteCustomers(id: number|string){
      return this.http.delete(this.CMP_APIUrl + `/Customers/${id}`);
    }

    getCountryDetails():Observable<any[]> {
      return this.http.get<any>(this.CMP_APIUrl + '/Countries');
    }
   
    addCountry(data:any) {
      return this.http.post(this.CMP_APIUrl + '/Countries', data);
    }

    updateCountry({ id, data }: { id: number | string; data: any; }) {
      return this.http.put(this.CMP_APIUrl + '/Countries/${id}', data);
    }
    
    deleteCountry(id: number|string){
      return this.http.delete(this.CMP_APIUrl + '/States/${id}');
    }

    getStateDetails():Observable<any[]> {
      return this.http.get<any>(this.CMP_APIUrl + '/States');
    }
   
    addState(data:any) {
      return this.http.post(this.CMP_APIUrl + '/States', data);
    }

    updateState({ id, data }: { id: number | string; data: any; }) {
      return this.http.put(this.CMP_APIUrl + '/States/${id}', data);
    }
    
    deleteState(id: number|string){
      return this.http.delete(this.CMP_APIUrl + '/State/${id}');
    }


}

