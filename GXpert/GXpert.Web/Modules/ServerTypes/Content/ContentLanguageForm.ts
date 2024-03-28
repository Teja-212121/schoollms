import { StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentLanguageForm {
    Name: StringEditor;
    Description: TextAreaEditor;
}

export class ContentLanguageForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentLanguage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentLanguageForm.init)  {
            ContentLanguageForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;

            initFormType(ContentLanguageForm, [
                'Name', w0,
                'Description', w1
            ]);
        }
    }
}