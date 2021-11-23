import { ProjectMonth } from './projectMonth';
import { ProjectHour } from "./projectHour";

export class Project {
   projectId: number = 0;
   projectName: string = '';
   projectBegin: Date;
   projectEnd: Date;
   projectDescription: string = '';
   projectStatus: string = 'W';
   projectMaxHours: number = 0;
   projectHours: ProjectHour[];
   projectMonths: ProjectMonth[];
}