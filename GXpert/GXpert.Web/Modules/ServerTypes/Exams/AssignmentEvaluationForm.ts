import { ServiceLookupEditor, StringEditor, LookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentEvaluationForm {
    AssignmentId: ServiceLookupEditor;
    EvalutionCriteria: StringEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
    BloomsIndex: LookupEditor;
    BloomsWeightage: DecimalEditor;
}

export class AssignmentEvaluationForm extends PrefixedContext {
    static readonly formKey = 'Exams.AssignmentEvaluation';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentEvaluationForm.init)  {
            AssignmentEvaluationForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = LookupEditor;
            var w3 = DecimalEditor;

            initFormType(AssignmentEvaluationForm, [
                'AssignmentId', w0,
                'EvalutionCriteria', w1,
                'ClassId', w2,
                'SubjectId', w2,
                'TopicId', w2,
                'BloomsIndex', w2,
                'BloomsWeightage', w3
            ]);
        }
    }
}