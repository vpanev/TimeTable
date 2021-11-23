import { ProjectService } from './../../shared/project.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee-project-edit-hours',
  templateUrl: './employee-project-edit-hours.component.html',
  styleUrls: ['./employee-project-edit-hours.component.css']
})
export class EmployeeProjectEditHoursComponent implements OnInit {

  constructor(public service: ProjectService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm) { }
}
