import { LookupEditor, ServiceLookupEditor, IntegerEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";

export interface AssignmentAttemptEvaluationForm {
    AssignmentId: LookupEditor;
    AssignmentAttemptId: ServiceLookupEditor;
    AssignmentEvaluationId: LookupEditor;
    MarksObtained: IntegerEditor;
    EvaluationStatus: EnumEditor;
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
            var w3 = EnumEditor;

            initFormType(AssignmentAttemptEvaluationForm, [
                'AssignmentId', w0,
                'AssignmentAttemptId', w1,
                'AssignmentEvaluationId', w0,
                'MarksObtained', w2,
                'EvaluationStatus', w3
            ]);
        }
    }
}

[EExamAttemptStatus]; // referenced types