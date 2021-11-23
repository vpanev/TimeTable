import { ProjectHour } from "./projectHour";

export class Employee {
   employeeId: number = 0;
   employeeEgn: string = '';
   employeeName: string = '';
   employeeSurname: string = '';
   employeeLastname: string = '';
   employeePosition: string = '';
   employeeHiredate: Date;
   projectHours: ProjectHour[];
}