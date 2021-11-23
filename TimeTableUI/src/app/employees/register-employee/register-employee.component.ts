import { EmployeeService } from './../../shared/employee.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';
import { Employee } from 'src/app/shared/models/employee';

@Component({
  selector: 'app-register-employee',
  templateUrl: './register-employee.component.html',
  styleUrls: ['./register-employee.component.css']
})
export class RegisterEmployeeComponent implements OnInit {

  constructor(public service: EmployeeService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form)
  }

  insertRecord(form: NgForm) {
    this.service.postEmployee().subscribe(res => {
      this.resetForm(form);
      this.toastr.success("Successfully registered a person!")
      this.service.refreshList();
    },
      err => {
        console.log(err);
        this.toastr.error("ERROR")
      })
  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Employee();
  }

}
