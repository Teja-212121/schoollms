import { StringEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentRatingForm {
    Name: StringEditor;
    Description: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentRatingForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentRating';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentRatingForm.init)  {
            ContentRatingForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(ContentRatingForm, [
                'Name', w0,
                'Description', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w2
            ]);
        }
    }
}