import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AssignmentEvaluationRow } from "./AssignmentEvaluationRow";

export interface AssignmentEvaluationColumns {
    Id: Column<AssignmentEvaluationRow>;
    AssignmentTitle: Column<AssignmentEvaluationRow>;
    EvalutionCriteria: Column<AssignmentEvaluationRow>;
    ClassTitle: Column<AssignmentEvaluationRow>;
    SubjectTitle: Column<AssignmentEvaluationRow>;
    TopicTitle: Column<AssignmentEvaluationRow>;
    BloomsIndexCoginitiveSkill: Column<AssignmentEvaluationRow>;
    BloomsWeightage: Column<AssignmentEvaluationRow>;
    InsertDate: Column<AssignmentEvaluationRow>;
    InsertUserId: Column<AssignmentEvaluationRow>;
    UpdateDate: Column<AssignmentEvaluationRow>;
    UpdateUserId: Column<AssignmentEvaluationRow>;
    IsActive: Column<AssignmentEvaluationRow>;
}

export class AssignmentEvaluationColumns extends ColumnsBase<AssignmentEvaluationRow> {
    static readonly columnsKey = 'Exams.AssignmentEvaluation';
    static readonly Fields = fieldsProxy<AssignmentEvaluationColumns>();
}