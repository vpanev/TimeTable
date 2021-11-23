import { Project } from './models/project';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private http: HttpClient) { }
  readonly baseUrl = "https://localhost:44301/api/Project/Projects";

  formData: Project = new Project();

  refreshList() {
    return this.http.get<any>(this.baseUrl);
  }
  postProject() {
    return this.http.post(this.baseUrl, this.formData);
  }
}
