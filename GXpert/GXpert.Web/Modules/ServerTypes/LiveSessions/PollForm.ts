import { StringEditor, EnumEditor, ServiceLookupEditor, IntegerEditor, DecimalEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EQuestionType } from "../Web/Enums.EQuestionType";

export interface PollForm {
    Question: StringEditor;
    EQuestionType: EnumEditor;
    Option1: StringEditor;
    Option2: StringEditor;
    Option3: StringEditor;
    Option4: StringEditor;
    Option5: StringEditor;
    RightAnswer: StringEditor;
    LiveSessionLogId: ServiceLookupEditor;
    TotalAttempts: IntegerEditor;
    AverageResponseTime: DecimalEditor;
    NumberOfCorrect: IntegerEditor;
    NumberOfWrong: IntegerEditor;
    BloomsTaxonomyId: LookupEditor;
    Weightage: DecimalEditor;
}

export class PollForm extends PrefixedContext {
    static readonly formKey = 'LiveSessions.Poll';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PollForm.init)  {
            PollForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = ServiceLookupEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = LookupEditor;

            initFormType(PollForm, [
                'Question', w0,
                'EQuestionType', w1,
                'Option1', w0,
                'Option2', w0,
                'Option3', w0,
                'Option4', w0,
                'Option5', w0,
                'RightAnswer', w0,
                'LiveSessionLogId', w2,
                'TotalAttempts', w3,
                'AverageResponseTime', w4,
                'NumberOfCorrect', w3,
                'NumberOfWrong', w3,
                'BloomsTaxonomyId', w5,
                'Weightage', w4
            ]);
        }
    }
}

[EQuestionType]; // referenced types