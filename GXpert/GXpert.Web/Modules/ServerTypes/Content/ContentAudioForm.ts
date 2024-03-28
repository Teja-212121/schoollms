import { StringEditor, LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentAudioForm {
    MediaFile: StringEditor;
    HlsFile: StringEditor;
    FileKeyUrl: StringEditor;
    Iv: StringEditor;
    ContentId: LookupEditor;
    LanguageId: IntegerEditor;
    UserId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentAudioForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentAudio';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentAudioForm.init)  {
            ContentAudioForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(ContentAudioForm, [
                'MediaFile', w0,
                'HlsFile', w0,
                'FileKeyUrl', w0,
                'Iv', w0,
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