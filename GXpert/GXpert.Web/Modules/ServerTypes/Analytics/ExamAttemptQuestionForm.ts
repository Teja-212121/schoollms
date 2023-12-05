import { ServiceLookupEditor, IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamAttemptQuestionForm {
    ExamAttemptId: ServiceLookupEditor;
    ExamQuestionId: IntegerEditor;
    OptionSelected: StringEditor;
    MarksObtained: IntegerEditor;
    Attemptstatus: IntegerEditor;
    OutOfmarks: IntegerEditor;
    Result: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ExamAttemptQuestionForm extends PrefixedContext {
    static readonly formKey = 'Analytics.ExamAttemptQuestion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptQuestionForm.init)  {
            ExamAttemptQuestionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(ExamAttemptQuestionForm, [
                'ExamAttemptId', w0,
                'ExamQuestionId', w1,
                'OptionSelected', w2,
                'MarksObtained', w1,
                'Attemptstatus', w1,
                'OutOfmarks', w1,
                'Result', w2,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}