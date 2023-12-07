import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface NotificationForm {
    NotificationGuid: StringEditor;
    Message: StringEditor;
    Title: StringEditor;
    CreatedOnUtc: DateEditor;
    SentTries: IntegerEditor;
    SentOnUtc: DateEditor;
    HasError: BooleanEditor;
    Result: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class NotificationForm extends PrefixedContext {
    static readonly formKey = 'Settings.Notification';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!NotificationForm.init)  {
            NotificationForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(NotificationForm, [
                'NotificationGuid', w0,
                'Message', w0,
                'Title', w0,
                'CreatedOnUtc', w1,
                'SentTries', w2,
                'SentOnUtc', w1,
                'HasError', w3,
                'Result', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}