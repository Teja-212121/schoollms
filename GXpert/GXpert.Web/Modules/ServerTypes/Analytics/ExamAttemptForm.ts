import { LookupEditor, IntegerEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamAttemptForm {
    ExamId: LookupEditor;
    StudentId: LookupEditor;
    TeacherId: LookupEditor;
    EStatus: IntegerEditor;
    TimeSpent: IntegerEditor;
    PlayListId: LookupEditor;
    StudentAnswerSheetUpload: StringEditor;
    TeacherCheckedPaperUpload: StringEditor;
    ActivationId: LookupEditor;
}

export class ExamAttemptForm extends PrefixedContext {
    static readonly formKey = 'Analytics.ExamAttempt';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptForm.init)  {
            ExamAttemptForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;

            initFormType(ExamAttemptForm, [
                'ExamId', w0,
                'StudentId', w0,
                'TeacherId', w0,
                'EStatus', w1,
                'TimeSpent', w1,
                'PlayListId', w0,
                'StudentAnswerSheetUpload', w2,
                'TeacherCheckedPaperUpload', w2,
                'ActivationId', w0
            ]);
        }
    }
}