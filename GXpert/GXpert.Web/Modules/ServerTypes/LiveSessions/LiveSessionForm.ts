import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LiveSessionForm {
    MeetingId: StringEditor;
    LiveProvider: IntegerEditor;
    Password: StringEditor;
    Secret: StringEditor;
    LiveAdditionalInfo: StringEditor;
    SearchTags: StringEditor;
}

export class LiveSessionForm extends PrefixedContext {
    static readonly formKey = 'LiveSessions.LiveSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LiveSessionForm.init)  {
            LiveSessionForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(LiveSessionForm, [
                'MeetingId', w0,
                'LiveProvider', w1,
                'Password', w0,
                'Secret', w0,
                'LiveAdditionalInfo', w0,
                'SearchTags', w0
            ]);
        }
    }
}