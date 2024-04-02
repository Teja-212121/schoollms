import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TenantForm {
    TenantName: StringEditor;
    OwnerId: IntegerEditor;
}

export class TenantForm extends PrefixedContext {
    static readonly formKey = 'Administration.Tenant';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TenantForm.init)  {
            TenantForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(TenantForm, [
                'TenantName', w0,
                'OwnerId', w1
            ]);
        }
    }
}