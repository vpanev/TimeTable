import { RegisterEmployeeOnProjectComponent } from './employees/register-employee-on-project/register-employee-on-project.component';
import { EmployeeProjectEditHoursComponent } from './employees/employee-project-edit-hours/employee-project-edit-hours.component';
import { FilterTextboxComponent } from './filter-textbox/filter-textbox.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { LeftSideNavComponent } from './left-side-nav/left-side-nav.component';
import { AccountTopMenuComponent } from './account-top-menu/account-top-menu.component';
import { EmployeeService } from './shared/employee.service';
import { EmployeeDetailComponent } from './employees/employee-detail/employee-detail.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { RegisterEmployeeComponent } from './employees/register-employee/register-employee.component';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { DetailsFormComponent } from './employees/details-form/details-form.component';
import { EmployeeProjectsDetailsComponent } from './employees/employee-projects-details/employee-projects-details.component';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { ProjectsComponent } from './projects/projects.component';
import { ProjectDetailComponent } from './projects/project-detail/project-detail.component';
import { RegisterProjectComponent } from './projects/register-project/register-project.component';
import { ProjectDetailsFormComponent } from './projects/project-details-form/project-details-form.component';

@NgModule({
  declarations: [
    AppComponent,
    LeftSideNavComponent,
    EmployeesComponent,
    AccountTopMenuComponent,
    EmployeeDetailComponent,
    FilterTextboxComponent,
    RegisterEmployeeComponent,
    DetailsFormComponent,
    EmployeeProjectsDetailsComponent,
    LoginComponent,
    RegisterComponent,
    ProjectsComponent,
    ProjectDetailComponent,
    RegisterProjectComponent,
    ProjectDetailsFormComponent,
    EmployeeProjectEditHoursComponent,
    RegisterEmployeeOnProjectComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    BsDatepickerModule.forRoot()
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
