import { ServiceLookupEditor, StringEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentEvaluationForm {
    AssignmentId: ServiceLookupEditor;
    EvalutionCriteria: StringEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    TopicId: IntegerEditor;
    BloomsIndex: IntegerEditor;
    BloomsWeightage: DecimalEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
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
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = BooleanEditor;

            initFormType(AssignmentEvaluationForm, [
                'AssignmentId', w0,
                'EvalutionCriteria', w1,
                'ClassId', w2,
                'SubjectId', w2,
                'TopicId', w2,
                'BloomsIndex', w2,
                'BloomsWeightage', w3,
                'InsertDate', w4,
                'InsertUserId', w2,
                'UpdateDate', w4,
                'UpdateUserId', w2,
                'IsActive', w5
            ]);
        }
    }
}