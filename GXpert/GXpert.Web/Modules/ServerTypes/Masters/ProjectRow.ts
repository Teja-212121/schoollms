import { fieldsProxy } from "@serenity-is/corelib";
import { EProjectType } from "../Web/Enums.EProjectType";

export interface ProjectRow {
    Id?: number;
    StudentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    Title?: string;
    Description?: string;
    EType?: EProjectType;
    StudentPrn?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
}

export abstract class ProjectRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.Project';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<ProjectRow>();
}