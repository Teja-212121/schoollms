import { IntegerEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PollResponseForm {
    PollId: IntegerEditor;
    StudentId: IntegerEditor;
    Response: StringEditor;
    ResponseTimeInSeconds: IntegerEditor;
    Score: IntegerEditor;
    LiveSessionLogId: IntegerEditor;
    ActivationId: IntegerEditor;
}

export class PollResponseForm extends PrefixedContext {
    static readonly formKey = 'Attendance.PollResponse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PollResponseForm.init)  {
            PollResponseForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(PollResponseForm, [
                'PollId', w0,
                'StudentId', w0,
                'Response', w1,
                'ResponseTimeInSeconds', w0,
                'Score', w0,
                'LiveSessionLogId', w0,
                'ActivationId', w0
            ]);
        }
    }
}