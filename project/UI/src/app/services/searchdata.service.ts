import { Injectable } from '@angular/core';  
import {HttpClient, HttpResponse} from '@angular/common/http';    
import {HttpHeaders} from '@angular/common/http';    
import { Observable } from 'rxjs';
@Injectable({  
  providedIn: 'root'  
})  
export class SearchdataService {  
  Url: string | undefined; 
  
  constructor(private http : HttpClient) {  
   }  
    
  // searchdata(model : any){  
  //   debugger;    
  //  return this.http.post<any>(this.searchUrl+'/search',model);    
  // }  
  // showdata(){  
  //   debugger;    
  //  return this.http.get<any>(this.searchUrl+'/showdata');    
  // }  

  searchdata(model : any){  
   return this.http.post<any>('https://localhost:44349/Api/Searchdata/search',model);    
  }  
  
  statusChange(customerId : number) : Observable<HttpResponse<any>> {
    return this.http.post<HttpResponse<any>>('https://localhost:44349/Api/ChangeStatus/status',{ customerId });
  }

  showdata():Observable<any[]> {  
   return this.http.get<any>('https://localhost:44349/Api/Searchdata/showdata');    
  }  
}
