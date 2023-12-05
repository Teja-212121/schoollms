import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PollResponseForm {
    PollId: IntegerEditor;
    StudentId: IntegerEditor;
    Response: StringEditor;
    ResponseTimeInSeconds: IntegerEditor;
    Score: IntegerEditor;
    LiveSessionLogId: IntegerEditor;
    ActivationId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
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
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(PollResponseForm, [
                'PollId', w0,
                'StudentId', w0,
                'Response', w1,
                'ResponseTimeInSeconds', w0,
                'Score', w0,
                'LiveSessionLogId', w0,
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