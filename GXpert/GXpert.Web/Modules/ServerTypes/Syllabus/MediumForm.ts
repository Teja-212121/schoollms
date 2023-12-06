import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MediumForm {
    Title: StringEditor;
    Description: StringEditor;
}

export class MediumForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Medium';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MediumForm.init)  {
            MediumForm.init = true;

            var w0 = StringEditor;

            initFormType(MediumForm, [
                'Title', w0,
                'Description', w0
            ]);
        }
    }
}