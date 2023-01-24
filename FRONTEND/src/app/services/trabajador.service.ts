import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http'; //para usar backend
import { Trabajador } from '../interface/trabajador';
import { Trabajadorequest } from '../interface/trabajadorequest';

@Injectable({
  providedIn: 'root'
})
export class TrabajadorService {
  private myAppUrl:string = environment.EndPoint;
  private MyMethodResumen: string = 'Trabajador/ResumenSalarioTrabajador/';

  constructor(private http: HttpClient) { }

  ResumenTrabajador(trabajador : Trabajadorequest ): Observable<Trabajador[]>{
    return this.http.post<Trabajador[]>(`${this.myAppUrl}${this.MyMethodResumen}`,trabajador);
  }
}
