import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SmsForm {
    ApiKey: StringEditor;
    Sender: StringEditor;
    EntityId: StringEditor;
    TemplateId: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SmsForm extends PrefixedContext {
    static readonly formKey = 'Settings.Sms';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SmsForm.init)  {
            SmsForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(SmsForm, [
                'ApiKey', w0,
                'Sender', w0,
                'EntityId', w0,
                'TemplateId', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}