import { ProjectService } from './../../shared/project.service';
import { Project } from './../../shared/models/project';
import { EmployeeService } from './../../shared/employee.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { Employee } from 'src/app/shared/models/employee';

@Component({
  selector: 'app-register-employee-on-project',
  templateUrl: './register-employee-on-project.component.html',
  styleUrls: ['./register-employee-on-project.component.css']
})
export class RegisterEmployeeOnProjectComponent implements OnInit {

  constructor(public employeeService: EmployeeService, private toastr: ToastrService, public projectService: ProjectService) { }

  ngOnInit(): void {
    this.refreshEmployeeList();
    this.refreshProjectList();
  }

  selectedValueEmployee: string = 'Избери служител';
  selectedValueProject: string = 'Избери проект';
  selectedId: number;

  // On-Click Method on dropdown control
  selectValueEmployee(employee: Employee) {
    this.selectedValueEmployee = employee.employeeName + ' ' + employee.employeeSurname + ' ' + employee.employeeLastname;
    this.selectedId = employee.employeeId;
  }
  selectValueProject(project: Project) {
    this.selectedValueProject = project.projectName;
    this.selectedId = project.projectId;
  }

  employeeList: any = []
  projectList: any = []
  refreshProjectList() {
    this.projectService.refreshList().subscribe(data => {
      this.projectList = data;
    })
  }
  refreshEmployeeList() {
    this.employeeService.refreshList().subscribe(data => {
      this.employeeList = data;
    });
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form)
  }

  insertRecord(form: NgForm) {
    this.employeeService.postEmployee().subscribe(res => {
      this.resetForm(form);
      this.toastr.success("Successfully registered a person!")
      this.employeeService.refreshList();
    },
      err => {
        console.log(err);
        this.toastr.error("ERROR")
      })
  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.employeeService.formData = new Employee();
  }
}
