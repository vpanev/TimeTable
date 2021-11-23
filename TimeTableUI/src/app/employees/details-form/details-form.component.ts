import { EmployeeService } from 'src/app/shared/employee.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-details-form',
  templateUrl: './details-form.component.html',
  styleUrls: ['./details-form.component.css']
})
export class DetailsFormComponent implements OnInit {

  constructor(public service: EmployeeService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {

  }

}
