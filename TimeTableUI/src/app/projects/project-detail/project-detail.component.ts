import { Project } from './../../shared/models/project';
import { ProjectService } from './../../shared/project.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-project-detail',
  templateUrl: './project-detail.component.html',
  styleUrls: ['./project-detail.component.css']
})
export class ProjectDetailComponent implements OnInit {

  constructor(public service: ProjectService, public toastr: ToastrService) { }


  ngOnInit(): void {
    this.refreshList();
  }

  list: any = [];

  item: any;

  refreshList() {
    this.service.refreshList().subscribe(data => {
      this.list = data;
      this.filteredProjects = this.list;
    });
  }

  filteredProjects: any[] = [];

  filter(data: string) {
    if (data) {
      this.filteredProjects = this.list.filter((project: Project) => {
        return project.projectName.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          project.projectDescription.toLowerCase().indexOf(data.toLowerCase()) > -1 ||
          project.projectStatus.toLowerCase().indexOf(data) > -1 ||
          project.projectBegin.valueOf().toLocaleString().indexOf(data) > -1 ||
          project.projectEnd.valueOf().toLocaleString().indexOf(data) > -1
      });
    } else {
      this.filteredProjects = this.list;
    }
  }

  finishProject() {
    if (confirm("Are you sure you want to finish the project? ")) {
      this.toastr.success("Successfully finished")
    } else {
      this.toastr.warning("Error finishing the project")
    }
  }
}
