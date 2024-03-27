import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SubjectRow } from "./SubjectRow";

export interface SubjectColumns {
    Id: Column<SubjectRow>;
    CourseName: Column<SubjectRow>;
    ClassTitle: Column<SubjectRow>;
    SemesterName: Column<SubjectRow>;
    Title: Column<SubjectRow>;
    SortOrder: Column<SubjectRow>;
    Weightage: Column<SubjectRow>;
    Thumbnail: Column<SubjectRow>;
    Description: Column<SubjectRow>;
}

export class SubjectColumns extends ColumnsBase<SubjectRow> {
    static readonly columnsKey = 'Syllabus.Subject';
    static readonly Fields = fieldsProxy<SubjectColumns>();
}