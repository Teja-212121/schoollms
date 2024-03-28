﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentCourseRow } from "./ContentCourseRow";

export interface ContentCourseColumns {
    Id: Column<ContentCourseRow>;
    ContentTitle: Column<ContentCourseRow>;
    CourseTitle: Column<ContentCourseRow>;
    ClassTitle: Column<ContentCourseRow>;
    SemesterTitle: Column<ContentCourseRow>;
    Username: Column<ContentCourseRow>;
    InsertDate: Column<ContentCourseRow>;
    InsertUserId: Column<ContentCourseRow>;
    UpdateDate: Column<ContentCourseRow>;
    UpdateUserId: Column<ContentCourseRow>;
    IsActive: Column<ContentCourseRow>;
}

export class ContentCourseColumns extends ColumnsBase<ContentCourseRow> {
    static readonly columnsKey = 'Content.ContentCourse';
    static readonly Fields = fieldsProxy<ContentCourseColumns>();
}