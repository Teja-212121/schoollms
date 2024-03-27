import { LookupEditor, DateEditor, DecimalEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicScoreForm {
    PreAcadamicsId: LookupEditor;
    PassedOutDate: DateEditor;
    MarksObtained: DecimalEditor;
    OutOfMarks: DecimalEditor;
    StudentId: LookupEditor;
    Remarks: StringEditor;
}

export class PreAcademicScoreForm extends PrefixedContext {
    static readonly formKey = 'Masters.PreAcademicScore';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PreAcademicScoreForm.init)  {
            PreAcademicScoreForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = DecimalEditor;
            var w3 = StringEditor;

            initFormType(PreAcademicScoreForm, [
                'PreAcadamicsId', w0,
                'PassedOutDate', w1,
                'MarksObtained', w2,
                'OutOfMarks', w2,
                'StudentId', w0,
                'Remarks', w3
            ]);
        }
    }
}