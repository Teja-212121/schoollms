import { ImageUploadEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentSubtitleForm {
    SubtitleFile: ImageUploadEditor;
    ContentId: LookupEditor;
    UserId: LookupEditor;
}

export class ContentSubtitleForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentSubtitle';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentSubtitleForm.init)  {
            ContentSubtitleForm.init = true;

            var w0 = ImageUploadEditor;
            var w1 = LookupEditor;

            initFormType(ContentSubtitleForm, [
                'SubtitleFile', w0,
                'ContentId', w1,
                'UserId', w1
            ]);
        }
    }
}