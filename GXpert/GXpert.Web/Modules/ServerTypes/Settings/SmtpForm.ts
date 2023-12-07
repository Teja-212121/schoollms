import { StringEditor, IntegerEditor, BooleanEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SmtpForm {
    Server: StringEditor;
    Port: IntegerEditor;
    Username: StringEditor;
    Password: StringEditor;
    IsSsl: BooleanEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SmtpForm extends PrefixedContext {
    static readonly formKey = 'Settings.Smtp';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SmtpForm.init)  {
            SmtpForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;

            initFormType(SmtpForm, [
                'Server', w0,
                'Port', w1,
                'Username', w0,
                'Password', w0,
                'IsSsl', w2,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w2
            ]);
        }
    }
}