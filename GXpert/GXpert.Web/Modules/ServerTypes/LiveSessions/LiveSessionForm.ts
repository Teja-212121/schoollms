import { StringEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LiveSessionForm {
    MeetingId: StringEditor;
    LiveProvider: IntegerEditor;
    Password: StringEditor;
    Secret: StringEditor;
    LiveAdditionalInfo: StringEditor;
    SearchTags: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
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
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(LiveSessionForm, [
                'MeetingId', w0,
                'LiveProvider', w1,
                'Password', w0,
                'Secret', w0,
                'LiveAdditionalInfo', w0,
                'SearchTags', w0,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}