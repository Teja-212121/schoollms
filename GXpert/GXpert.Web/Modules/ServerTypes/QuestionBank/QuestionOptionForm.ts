import { ServiceLookupEditor, HtmlContentEditor, BooleanEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionOptionForm {
    QuestionId: ServiceLookupEditor;
    OptionText: HtmlContentEditor;
    IsCorrect: BooleanEditor;
    SortOrder: DecimalEditor;
    Weightage: DecimalEditor;
}

export class QuestionOptionForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.QuestionOption';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionOptionForm.init)  {
            QuestionOptionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = HtmlContentEditor;
            var w2 = BooleanEditor;
            var w3 = DecimalEditor;

            initFormType(QuestionOptionForm, [
                'QuestionId', w0,
                'OptionText', w1,
                'IsCorrect', w2,
                'SortOrder', w3,
                'Weightage', w3
            ]);
        }
    }
}