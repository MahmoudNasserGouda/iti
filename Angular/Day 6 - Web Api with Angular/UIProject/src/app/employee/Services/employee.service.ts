import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../Models/employee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseApiUrl: string="https://localhost:7153";
  constructor(private http: HttpClient)
  {

  }

  getAllEmployees() : Observable<Employee[]>
  {
    return this.http.get<Employee[]>(this.baseApiUrl+ '/api/Employee');
  }

  addEmployee(addEmployee: Employee): Observable<Employee>
  {
    addEmployee.id = 'd4999d2c-41fd-4a54-b6cd-d871512ac777';
    return this.http.post<Employee>(this.baseApiUrl+ '/api/Employee', addEmployee);
  }

  getEmployee(id:string)
  {
    return this.http.get<Employee>(this.baseApiUrl+ '/api/Employee/'+id);
  }

  updateEmployee(id:string, employeeUpdate:Employee): Observable<Employee>
  {
    return this.http.put<Employee>(this.baseApiUrl+ '/api/Employee/'+id, employeeUpdate);
  }

  deleteEmployee(id:string): Observable<Employee>
  {
    return this.http.delete<Employee>(this.baseApiUrl+ '/api/Employee/'+id);
  }
}
