import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Employee } from './models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }
  readonly baseUrl = "https://localhost:44301/api/Home/Employees";

  formData: Employee = new Employee();

  refreshList() {
    return this.http.get<any>(this.baseUrl);
  }
  postEmployee() {
    return this.http.post(this.baseUrl, this.formData);
  }

  // postClothDetail() {
  //   return this.http.post(this.baseUrl, this.formData);
  // }
  // putClothDetail() {
  //   return this.http.put(`${this.baseUrl}/${this.formData.clothId}`, this.formData);
  // }
  // deleteClothDetail(id: number) {
  //   return this.http.delete(`${this.baseUrl}/${id}`);
  // }
}