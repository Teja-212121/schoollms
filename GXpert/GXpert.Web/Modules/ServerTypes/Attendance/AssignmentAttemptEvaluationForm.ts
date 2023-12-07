import { IntegerEditor, ServiceLookupEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentAttemptEvaluationForm {
    AssignmentId: IntegerEditor;
    AssignmentAttemptId: ServiceLookupEditor;
    AssignmentEvaluationId: IntegerEditor;
    MarksObtained: IntegerEditor;
    EvaluationStatus: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AssignmentAttemptEvaluationForm extends PrefixedContext {
    static readonly formKey = 'Attendance.AssignmentAttemptEvaluation';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentAttemptEvaluationForm.init)  {
            AssignmentAttemptEvaluationForm.init = true;

            var w0 = IntegerEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(AssignmentAttemptEvaluationForm, [
                'AssignmentId', w0,
                'AssignmentAttemptId', w1,
                'AssignmentEvaluationId', w0,
                'MarksObtained', w0,
                'EvaluationStatus', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}