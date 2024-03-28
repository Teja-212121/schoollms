import { StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentRatingForm {
    Name: StringEditor;
    Description: TextAreaEditor;
}

export class ContentRatingForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentRating';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentRatingForm.init)  {
            ContentRatingForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;

            initFormType(ContentRatingForm, [
                'Name', w0,
                'Description', w1
            ]);
        }
    }
}