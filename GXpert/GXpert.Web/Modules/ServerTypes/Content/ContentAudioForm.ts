import { StringEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentAudioForm {
    MediaFile: StringEditor;
    HlsFile: StringEditor;
    FileKeyUrl: StringEditor;
    Iv: StringEditor;
    ContentId: LookupEditor;
    LanguageId: LookupEditor;
    UserId: LookupEditor;
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

            initFormType(ContentAudioForm, [
                'MediaFile', w0,
                'HlsFile', w0,
                'FileKeyUrl', w0,
                'Iv', w0,
                'ContentId', w1,
                'LanguageId', w1,
                'UserId', w1
            ]);
        }
    }
}