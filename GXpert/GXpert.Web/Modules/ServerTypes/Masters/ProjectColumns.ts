import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EProjectType } from "../Web/Enums.EProjectType";
import { ProjectRow } from "./ProjectRow";

export interface ProjectColumns {
    Id: Column<ProjectRow>;
    StudentPrn: Column<ProjectRow>;
    CourseTitle: Column<ProjectRow>;
    ClassTitle: Column<ProjectRow>;
    SemesterTitle: Column<ProjectRow>;
    Title: Column<ProjectRow>;
    Description: Column<ProjectRow>;
    EType: Column<ProjectRow>;
}

export class ProjectColumns extends ColumnsBase<ProjectRow> {
    static readonly columnsKey = 'Masters.Project';
    static readonly Fields = fieldsProxy<ProjectColumns>();
}

[EProjectType]; // referenced types