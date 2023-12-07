import { ServiceLookupEditor, StringEditor, BooleanEditor, DecimalEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionOptionForm {
    QuestionId: ServiceLookupEditor;
    OptionText: StringEditor;
    IsCorrect: BooleanEditor;
    SortOrder: DecimalEditor;
    Weightage: DecimalEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class QuestionOptionForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.QuestionOption';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionOptionForm.init)  {
            QuestionOptionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = IntegerEditor;

            initFormType(QuestionOptionForm, [
                'QuestionId', w0,
                'OptionText', w1,
                'IsCorrect', w2,
                'SortOrder', w3,
                'Weightage', w3,
                'InsertDate', w4,
                'InsertUserId', w5,
                'UpdateDate', w4,
                'UpdateUserId', w5,
                'IsActive', w2
            ]);
        }
    }
}