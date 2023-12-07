import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
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
    InsertDate: Column<ExamAttemptRow>;
    InsertUserId: Column<ExamAttemptRow>;
    UpdateDate: Column<ExamAttemptRow>;
    UpdateUserId: Column<ExamAttemptRow>;
    IsActive: Column<ExamAttemptRow>;
}

export class ExamAttemptColumns extends ColumnsBase<ExamAttemptRow> {
    static readonly columnsKey = 'Analytics.ExamAttempt';
    static readonly Fields = fieldsProxy<ExamAttemptColumns>();
}