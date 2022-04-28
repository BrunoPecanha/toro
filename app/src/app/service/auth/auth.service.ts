import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {  map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })};

  constructor(private http: HttpClient) {   
  }  
  
  protected url(param: string = ""): string {
    return `${environment.api_url}/investor/${param}`;
  }


  async login(email: string, password: string): Promise<any> {
    try {
      return await this.http.post<{ data: any, valid: boolean, message: string }>(this.url('login'), {email, password}, this.httpOptions)
        .pipe(map(x => {
          return {
            message: x.message,
            valid: x.valid,
            data: x.data
          }
        })).toPromise();         
    } catch (error) {
      throw error;
   
    }
  }    


  create(cpf: string, email: string, password: string): Observable<any> {
    return this.http.post(this.url('register'), {
      cpf,
      email,
      password
    }, this.httpOptions);
  }
}
