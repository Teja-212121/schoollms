import { StringEditor, LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentSubtitleForm {
    SubtitleFile: StringEditor;
    ContentId: LookupEditor;
    LanguageId: IntegerEditor;
    UserId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentSubtitleForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentSubtitle';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentSubtitleForm.init)  {
            ContentSubtitleForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(ContentSubtitleForm, [
                'SubtitleFile', w0,
                'ContentId', w1,
                'LanguageId', w2,
                'UserId', w1,
                'InsertDate', w3,
                'InsertUserId', w2,
                'UpdateDate', w3,
                'UpdateUserId', w2,
                'IsActive', w2
            ]);
        }
    }
}