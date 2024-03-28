import { StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentLicenseForm {
    Name: StringEditor;
    Description: TextAreaEditor;
}

export class ContentLicenseForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentLicense';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentLicenseForm.init)  {
            ContentLicenseForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;

            initFormType(ContentLicenseForm, [
                'Name', w0,
                'Description', w1
            ]);
        }
    }
}