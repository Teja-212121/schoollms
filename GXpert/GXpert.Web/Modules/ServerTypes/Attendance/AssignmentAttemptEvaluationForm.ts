import { LookupEditor, ServiceLookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentAttemptEvaluationForm {
    AssignmentId: LookupEditor;
    AssignmentAttemptId: ServiceLookupEditor;
    AssignmentEvaluationId: LookupEditor;
    MarksObtained: IntegerEditor;
    EvaluationStatus: IntegerEditor;
}

export class AssignmentAttemptEvaluationForm extends PrefixedContext {
    static readonly formKey = 'Attendance.AssignmentAttemptEvaluation';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentAttemptEvaluationForm.init)  {
            AssignmentAttemptEvaluationForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = IntegerEditor;

            initFormType(AssignmentAttemptEvaluationForm, [
                'AssignmentId', w0,
                'AssignmentAttemptId', w1,
                'AssignmentEvaluationId', w0,
                'MarksObtained', w2,
                'EvaluationStatus', w2
            ]);
        }
    }
}