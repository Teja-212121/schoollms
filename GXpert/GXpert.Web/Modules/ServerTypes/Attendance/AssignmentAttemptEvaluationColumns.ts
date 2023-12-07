import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";
import { AssignmentAttemptEvaluationRow } from "./AssignmentAttemptEvaluationRow";

export interface AssignmentAttemptEvaluationColumns {
    Id: Column<AssignmentAttemptEvaluationRow>;
    AssignmentTitle: Column<AssignmentAttemptEvaluationRow>;
    AssignmentAttemptFileUploaded: Column<AssignmentAttemptEvaluationRow>;
    AssignmentEvaluationEvalutionCriteria: Column<AssignmentAttemptEvaluationRow>;
    MarksObtained: Column<AssignmentAttemptEvaluationRow>;
    EvaluationStatus: Column<AssignmentAttemptEvaluationRow>;
}

export class AssignmentAttemptEvaluationColumns extends ColumnsBase<AssignmentAttemptEvaluationRow> {
    static readonly columnsKey = 'Attendance.AssignmentAttemptEvaluation';
    static readonly Fields = fieldsProxy<AssignmentAttemptEvaluationColumns>();
}

[EExamAttemptStatus]; // referenced types