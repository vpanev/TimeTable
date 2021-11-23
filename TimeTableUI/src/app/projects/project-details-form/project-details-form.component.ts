import { ProjectService } from './../../shared/project.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-project-details-form',
  templateUrl: './project-details-form.component.html',
  styleUrls: ['./project-details-form.component.css']
})
export class ProjectDetailsFormComponent implements OnInit {

  constructor(public service: ProjectService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm) {

  }

}
