import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ExamSectionRow } from "./ExamSectionRow";

export interface ExamSectionColumns {
    Id: Column<ExamSectionRow>;
    ExamTitle: Column<ExamSectionRow>;
    Title: Column<ExamSectionRow>;
    Instructions: Column<ExamSectionRow>;
    DurationInSeconds: Column<ExamSectionRow>;
    SortOrder: Column<ExamSectionRow>;
    ParentTitle: Column<ExamSectionRow>;
    NumberOfQuestions: Column<ExamSectionRow>;
    NumberOfMandatoryQuestions: Column<ExamSectionRow>;
    SearchTags: Column<ExamSectionRow>;
    CourseTitle: Column<ExamSectionRow>;
    ClassTitle: Column<ExamSectionRow>;
    SemesterTitle: Column<ExamSectionRow>;
    SubjectTitle: Column<ExamSectionRow>;
    TopicTitle: Column<ExamSectionRow>;
}

export class ExamSectionColumns extends ColumnsBase<ExamSectionRow> {
    static readonly columnsKey = 'Exams.ExamSection';
    static readonly Fields = fieldsProxy<ExamSectionColumns>();
}