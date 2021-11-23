import { ProjectService } from './../../shared/project.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormControl, NgForm } from '@angular/forms';
import { Project } from 'src/app/shared/models/project';

@Component({
  selector: 'app-register-project',
  templateUrl: './register-project.component.html',
  styleUrls: ['./register-project.component.css']
})
export class RegisterProjectComponent implements OnInit {

  constructor(public service: ProjectService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form)
  }

  insertRecord(form: NgForm) {
    this.service.postProject().subscribe(res => {
      this.resetForm(form);
      this.toastr.success("Project register was successful")
      this.service.refreshList();
    },
      err => {
        console.log(err);
        this.toastr.error("ERROR")
      })
  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Project();
  }

}
