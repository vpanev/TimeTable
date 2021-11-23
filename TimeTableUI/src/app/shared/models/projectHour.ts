import { ProjectMonth } from './projectMonth';
import { Employee } from './employee';
import { Project } from "./project";
export class ProjectHour {
   projectId: number = 0;
   employeeId: number = 0;
   projectTaskdate: Date;
   projectMonthId: number = 0;
   projectTask: string = '';
   projectHours: number = 0;
   employee: Employee;
   project: Project;
   projectMonth: ProjectMonth;
}