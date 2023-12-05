import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamAttemptForm {
    ExamId: IntegerEditor;
    StudentId: IntegerEditor;
    TeacherId: IntegerEditor;
    EStatus: IntegerEditor;
    TimeSpent: IntegerEditor;
    PlayListId: IntegerEditor;
    StudentAnswerSheetUpload: StringEditor;
    TeacherCheckedPaperUpload: StringEditor;
    ActivationId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ExamAttemptForm extends PrefixedContext {
    static readonly formKey = 'Analytics.ExamAttempt';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptForm.init)  {
            ExamAttemptForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(ExamAttemptForm, [
                'ExamId', w0,
                'StudentId', w0,
                'TeacherId', w0,
                'EStatus', w0,
                'TimeSpent', w0,
                'PlayListId', w0,
                'StudentAnswerSheetUpload', w1,
                'TeacherCheckedPaperUpload', w1,
                'ActivationId', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}