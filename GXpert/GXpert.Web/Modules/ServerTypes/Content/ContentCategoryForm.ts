import { StringEditor, BooleanEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentCategoryForm {
    Name: StringEditor;
    Description: StringEditor;
    IsGlobal: BooleanEditor;
    MediaCount: IntegerEditor;
    Thumbnail: StringEditor;
    ListingThumbnail: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentCategoryForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentCategory';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentCategoryForm.init)  {
            ContentCategoryForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(ContentCategoryForm, [
                'Name', w0,
                'Description', w0,
                'IsGlobal', w1,
                'MediaCount', w2,
                'Thumbnail', w0,
                'ListingThumbnail', w0,
                'InsertDate', w3,
                'InsertUserId', w2,
                'UpdateDate', w3,
                'UpdateUserId', w2,
                'IsActive', w2
            ]);
        }
    }
}