import { StringEditor, BooleanEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionForm {
    QuestionText: StringEditor;
    Explaination: StringEditor;
    IsSubjective: BooleanEditor;
    EQuestionType: IntegerEditor;
    EDifficultyLevel: IntegerEditor;
    QuestionCommonDataId: ServiceLookupEditor;
    QuestionCommonDataSortOrder: DecimalEditor;
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
            var w5 = DateEditor;

            initFormType(QuestionForm, [
                'QuestionText', w0,
                'Explaination', w0,
                'IsSubjective', w1,
                'EQuestionType', w2,
                'EDifficultyLevel', w2,
                'QuestionCommonDataId', w3,
                'QuestionCommonDataSortOrder', w4,
                'ClassId', w2,
                'SubjectId', w2,
                'TopicId', w2,
                'BloomsIndex', w2,
                'BloomsWeightage', w4,
                'InsertDate', w5,
                'InsertUserId', w2,
                'UpdateDate', w5,
                'UpdateUserId', w2,
                'IsActive', w1
            ]);
        }
    }
}