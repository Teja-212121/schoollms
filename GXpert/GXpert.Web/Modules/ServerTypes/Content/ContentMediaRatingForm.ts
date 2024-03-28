import { LookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentMediaRatingForm {
    ContentId: LookupEditor;
    RatingId: LookupEditor;
    Score: IntegerEditor;
    UserId: LookupEditor;
}

export class ContentMediaRatingForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentMediaRating';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentMediaRatingForm.init)  {
            ContentMediaRatingForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;

            initFormType(ContentMediaRatingForm, [
                'ContentId', w0,
                'RatingId', w0,
                'Score', w1,
                'UserId', w0
            ]);
        }
    }
}