import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AssignmentAttemptEvaluationRow } from "./AssignmentAttemptEvaluationRow";

export interface AssignmentAttemptEvaluationColumns {
    Id: Column<AssignmentAttemptEvaluationRow>;
    AssignmentTitle: Column<AssignmentAttemptEvaluationRow>;
    AssignmentAttemptFileUploaded: Column<AssignmentAttemptEvaluationRow>;
    AssignmentEvaluationEvalutionCriteria: Column<AssignmentAttemptEvaluationRow>;
    MarksObtained: Column<AssignmentAttemptEvaluationRow>;
    EvaluationStatus: Column<AssignmentAttemptEvaluationRow>;
    InsertDate: Column<AssignmentAttemptEvaluationRow>;
    InsertUserId: Column<AssignmentAttemptEvaluationRow>;
    UpdateDate: Column<AssignmentAttemptEvaluationRow>;
    UpdateUserId: Column<AssignmentAttemptEvaluationRow>;
    IsActive: Column<AssignmentAttemptEvaluationRow>;
}

export class AssignmentAttemptEvaluationColumns extends ColumnsBase<AssignmentAttemptEvaluationRow> {
    static readonly columnsKey = 'Attendance.AssignmentAttemptEvaluation';
    static readonly Fields = fieldsProxy<AssignmentAttemptEvaluationColumns>();
}