import { StringEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PollForm {
    Question: StringEditor;
    EQuestionType: IntegerEditor;
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
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DecimalEditor;
            var w4 = LookupEditor;

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
                'TotalAttempts', w1,
                'AverageResponseTime', w3,
                'NumberOfCorrect', w1,
                'NumberOfWrong', w1,
                'BloomsTaxonomyId', w4,
                'Weightage', w3
            ]);
        }
    }
}