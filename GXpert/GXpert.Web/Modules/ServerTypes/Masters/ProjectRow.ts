import { fieldsProxy } from "@serenity-is/corelib";

export interface ProjectRow {
    Id?: number;
    StudentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    Title?: string;
    Description?: string;
    EType?: number;
    StudentPrn?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
}

export abstract class ProjectRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.Project';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProjectRow>();
}