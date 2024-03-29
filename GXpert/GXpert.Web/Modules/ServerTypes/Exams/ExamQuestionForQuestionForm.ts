import { StringEditor, LookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamQuestionForQuestionForm {
    RowIds: StringEditor;
    ExamId: LookupEditor;
    ExamSectionId: LookupEditor;
    SortOrder: DecimalEditor;
    Marks: DecimalEditor;
}

export class ExamQuestionForQuestionForm extends PrefixedContext {
    static readonly formKey = 'Exams.ExamQuestionForQuestionForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamQuestionForQuestionForm.init)  {
            ExamQuestionForQuestionForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DecimalEditor;

            initFormType(ExamQuestionForQuestionForm, [
                'RowIds', w0,
                'ExamId', w1,
                'ExamSectionId', w1,
                'SortOrder', w2,
                'Marks', w2
            ]);
        }
    }
}