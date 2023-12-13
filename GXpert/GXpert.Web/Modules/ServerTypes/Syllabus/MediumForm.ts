import { StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MediumForm {
    Title: StringEditor;
    Description: TextAreaEditor;
}

export class MediumForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Medium';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MediumForm.init)  {
            MediumForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;

            initFormType(MediumForm, [
                'Title', w0,
                'Description', w1
            ]);
        }
    }
}