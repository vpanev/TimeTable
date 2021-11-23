import { RegisterEmployeeOnProjectComponent } from './employees/register-employee-on-project/register-employee-on-project.component';
import { EmployeeProjectEditHoursComponent } from './employees/employee-project-edit-hours/employee-project-edit-hours.component';
import { ProjectDetailsFormComponent } from './projects/project-details-form/project-details-form.component';
import { RegisterProjectComponent } from './projects/register-project/register-project.component';
import { ProjectsComponent } from './projects/projects.component';
import { EmployeeProjectsDetailsComponent } from './employees/employee-projects-details/employee-projects-details.component';
import { DetailsFormComponent } from './employees/details-form/details-form.component';
import { RegisterEmployeeComponent } from './employees/register-employee/register-employee.component';
import { EmployeesComponent } from './employees/employees.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: "employees", component: EmployeesComponent },
  { path: "employees/register-employee", component: RegisterEmployeeComponent },
  { path: "employees/details-form", component: DetailsFormComponent },
  { path: "employees/employee-projects-details", component: EmployeeProjectsDetailsComponent },
  { path: "employees/employee-project-edit-hours", component: EmployeeProjectEditHoursComponent },
  { path: "register-employee-on-project", component: RegisterEmployeeOnProjectComponent },
  { path: "projects", component: ProjectsComponent },
  { path: "projects/register-project", component: RegisterProjectComponent },
  { path: "projects/project-details-form", component: ProjectDetailsFormComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
