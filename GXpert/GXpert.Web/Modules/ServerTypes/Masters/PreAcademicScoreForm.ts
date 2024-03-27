import { IntegerEditor, DateEditor, DecimalEditor, LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicScoreForm {
    PreAcadamicsId: IntegerEditor;
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

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = DecimalEditor;
            var w3 = LookupEditor;
            var w4 = StringEditor;

            initFormType(PreAcademicScoreForm, [
                'PreAcadamicsId', w0,
                'PassedOutDate', w1,
                'MarksObtained', w2,
                'OutOfMarks', w2,
                'StudentId', w3,
                'Remarks', w4
            ]);
        }
    }
}