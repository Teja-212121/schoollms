import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";
import { ExamAttemptRow } from "./ExamAttemptRow";

export interface ExamAttemptColumns {
    Id: Column<ExamAttemptRow>;
    ExamTitle: Column<ExamAttemptRow>;
    StudentPrn: Column<ExamAttemptRow>;
    TeacherPrn: Column<ExamAttemptRow>;
    EStatus: Column<ExamAttemptRow>;
    TimeSpent: Column<ExamAttemptRow>;
    PlayListTitle: Column<ExamAttemptRow>;
    StudentAnswerSheetUpload: Column<ExamAttemptRow>;
    TeacherCheckedPaperUpload: Column<ExamAttemptRow>;
    ActivationDeviceId: Column<ExamAttemptRow>;
}

export class ExamAttemptColumns extends ColumnsBase<ExamAttemptRow> {
    static readonly columnsKey = 'Analytics.ExamAttempt';
    static readonly Fields = fieldsProxy<ExamAttemptColumns>();
}

[EExamAttemptStatus]; // referenced types