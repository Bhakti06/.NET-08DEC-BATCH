import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormService {

  constructor(private http:HttpClient) { }
  
  createUser(createResource:any){
    console.log(createResource);
    return this.http.post('https://localhost:5001/api/FeedBack',createResource);
  }

  getForm(){ // To fetch the data from the User.
    let apiurl="https://localhost:5001/api/FeedBack";
    return this.http.get<any>(apiurl);  // Where http is HttpClient object, get method to get the data and apiurl the variable name that contains the data. 
  }
  getFormId(emplyoeeId:string){
    let apiurl="https://localhost:5001/api/FeedBack"+emplyoeeId;
    return this.http.get(apiurl);
  }
}
