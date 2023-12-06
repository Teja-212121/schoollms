import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SmsForm {
    ApiKey: StringEditor;
    Sender: StringEditor;
    EntityId: StringEditor;
    TemplateId: StringEditor;
}

export class SmsForm extends PrefixedContext {
    static readonly formKey = 'Settings.Sms';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SmsForm.init)  {
            SmsForm.init = true;

            var w0 = StringEditor;

            initFormType(SmsForm, [
                'ApiKey', w0,
                'Sender', w0,
                'EntityId', w0,
                'TemplateId', w0
            ]);
        }
    }
}