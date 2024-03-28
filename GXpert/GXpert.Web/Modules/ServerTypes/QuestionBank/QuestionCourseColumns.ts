import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { QuestionCourseRow } from "./QuestionCourseRow";

export interface QuestionCourseColumns {
    Id: Column<QuestionCourseRow>;
    QuestionText: Column<QuestionCourseRow>;
    CourseTitle: Column<QuestionCourseRow>;
    ClassTitle: Column<QuestionCourseRow>;
    SemesterTitle: Column<QuestionCourseRow>;
    Username: Column<QuestionCourseRow>;
    InsertDate: Column<QuestionCourseRow>;
    InsertUserId: Column<QuestionCourseRow>;
    UpdateDate: Column<QuestionCourseRow>;
    UpdateUserId: Column<QuestionCourseRow>;
    IsActive: Column<QuestionCourseRow>;
}

export class QuestionCourseColumns extends ColumnsBase<QuestionCourseRow> {
    static readonly columnsKey = 'QuestionBank.QuestionCourse';
    static readonly Fields = fieldsProxy<QuestionCourseColumns>();
}