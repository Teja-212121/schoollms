import { DateEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LiveSessionLogForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    TeacherId: LookupEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
}

export class LiveSessionLogForm extends PrefixedContext {
    static readonly formKey = 'LiveSessions.LiveSessionLog';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LiveSessionLogForm.init)  {
            LiveSessionLogForm.init = true;

            var w0 = DateEditor;
            var w1 = LookupEditor;

            initFormType(LiveSessionLogForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'TeacherId', w1,
                'ClassId', w1,
                'SubjectId', w1
            ]);
        }
    }
}