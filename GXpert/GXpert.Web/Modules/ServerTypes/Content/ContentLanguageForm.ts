import { StringEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentLanguageForm {
    Name: StringEditor;
    Description: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentLanguageForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentLanguage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentLanguageForm.init)  {
            ContentLanguageForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(ContentLanguageForm, [
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