import { LookupEditor, StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PollResponseForm {
    PollId: LookupEditor;
    StudentId: LookupEditor;
    Response: StringEditor;
    ResponseTimeInSeconds: IntegerEditor;
    Score: IntegerEditor;
    LiveSessionLogId: LookupEditor;
    ActivationId: LookupEditor;
}

export class PollResponseForm extends PrefixedContext {
    static readonly formKey = 'Attendance.PollResponse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PollResponseForm.init)  {
            PollResponseForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;

            initFormType(PollResponseForm, [
                'PollId', w0,
                'StudentId', w0,
                'Response', w1,
                'ResponseTimeInSeconds', w2,
                'Score', w2,
                'LiveSessionLogId', w0,
                'ActivationId', w0
            ]);
        }
    }
}