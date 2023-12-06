import { StringEditor, BooleanEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionForm {
    QuestionText: StringEditor;
    Explaination: StringEditor;
    IsSubjective: BooleanEditor;
    EQuestionType: IntegerEditor;
    EDifficultyLevel: IntegerEditor;
    QuestionCommonDataId: ServiceLookupEditor;
    QuestionCommonDataSortOrder: DecimalEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
    BloomsIndex: LookupEditor;
    BloomsWeightage: DecimalEditor;
}

export class QuestionForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.Question';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionForm.init)  {
            QuestionForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;
            var w3 = ServiceLookupEditor;
            var w4 = DecimalEditor;
            var w5 = LookupEditor;

            initFormType(QuestionForm, [
                'QuestionText', w0,
                'Explaination', w0,
                'IsSubjective', w1,
                'EQuestionType', w2,
                'EDifficultyLevel', w2,
                'QuestionCommonDataId', w3,
                'QuestionCommonDataSortOrder', w4,
                'ClassId', w5,
                'SubjectId', w5,
                'TopicId', w5,
                'BloomsIndex', w5,
                'BloomsWeightage', w4
            ]);
        }
    }
}