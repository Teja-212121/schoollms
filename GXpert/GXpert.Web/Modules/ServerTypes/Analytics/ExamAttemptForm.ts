import { LookupEditor, EnumEditor, IntegerEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";

export interface ExamAttemptForm {
    ExamId: LookupEditor;
    StudentId: LookupEditor;
    TeacherId: LookupEditor;
    EStatus: EnumEditor;
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
            var w1 = EnumEditor;
            var w2 = IntegerEditor;
            var w3 = StringEditor;

            initFormType(ExamAttemptForm, [
                'ExamId', w0,
                'StudentId', w0,
                'TeacherId', w0,
                'EStatus', w1,
                'TimeSpent', w2,
                'PlayListId', w0,
                'StudentAnswerSheetUpload', w3,
                'TeacherCheckedPaperUpload', w3,
                'ActivationId', w0
            ]);
        }
    }
}

[EExamAttemptStatus]; // referenced types