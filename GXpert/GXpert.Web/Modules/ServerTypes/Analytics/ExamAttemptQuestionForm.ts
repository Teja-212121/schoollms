import { ServiceLookupEditor, LookupEditor, StringEditor, IntegerEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EAttemptStatus } from "../Web/Enums.EAttemptStatus";

export interface ExamAttemptQuestionForm {
    ExamAttemptId: ServiceLookupEditor;
    ExamQuestionId: LookupEditor;
    OptionSelected: StringEditor;
    MarksObtained: IntegerEditor;
    Attemptstatus: EnumEditor;
    OutOfmarks: IntegerEditor;
    Result: StringEditor;
}

export class ExamAttemptQuestionForm extends PrefixedContext {
    static readonly formKey = 'Analytics.ExamAttemptQuestion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptQuestionForm.init)  {
            ExamAttemptQuestionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;
            var w3 = IntegerEditor;
            var w4 = EnumEditor;

            initFormType(ExamAttemptQuestionForm, [
                'ExamAttemptId', w0,
                'ExamQuestionId', w1,
                'OptionSelected', w2,
                'MarksObtained', w3,
                'Attemptstatus', w4,
                'OutOfmarks', w3,
                'Result', w2
            ]);
        }
    }
}

[EAttemptStatus]; // referenced types