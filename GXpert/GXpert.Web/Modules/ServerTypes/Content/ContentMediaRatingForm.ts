import { LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentMediaRatingForm {
    ContentId: LookupEditor;
    RatingId: IntegerEditor;
    Score: IntegerEditor;
    UserId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
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
            var w2 = DateEditor;

            initFormType(ContentMediaRatingForm, [
                'ContentId', w0,
                'RatingId', w1,
                'Score', w1,
                'UserId', w0,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w1
            ]);
        }
    }
}