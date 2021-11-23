import { Employee } from './../../shared/models/employee';
import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: ['./employee-detail.component.css']
})
export class EmployeeDetailComponent implements OnInit {

  constructor(public service: EmployeeService) { }

  ngOnInit(): void {
    this.refreshList();
  }

  list: any = [];

  item: any;

  refreshList() {
    this.service.refreshList().subscribe(data => {
      this.list = data;
      this.filteredEmployees = this.list;
    });
  }

  filteredEmployees: any[] = [];

  filter(data: string) {
    if (data) {
      this.filteredEmployees = this.list.filter((employee: Employee) => {
        return employee.employeeEgn.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          employee.employeeName.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          employee.employeeSurname.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          employee.employeeLastname.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          employee.employeePosition.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          employee.employeeHiredate.valueOf().toLocaleString().indexOf(data) > -1
      });
    } else {
      this.filteredEmployees = this.list;
    }
  }
}
