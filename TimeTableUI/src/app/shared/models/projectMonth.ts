import { ProjectHour } from "./projectHour";
import { Project } from "./project";

export class ProjectMonth {
   projectMonthId: number = 0;
   projectId: number = 0;
   projectYear: number = 0;
   projectMonth1: number = 0;
   projectMonthStatus: string = '';
   project: Project;
   projectHours: ProjectHour[];
}