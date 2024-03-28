import { StringEditor, IntegerEditor, ServiceLookupEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentCommentForm {
    CommentText: StringEditor;
    CommentLeft: IntegerEditor;
    CommentRight: IntegerEditor;
    TreeId: IntegerEditor;
    CommentLevel: IntegerEditor;
    ParentId: ServiceLookupEditor;
    ContentId: LookupEditor;
    UserId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentCommentForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentComment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentCommentForm.init)  {
            ContentCommentForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = LookupEditor;
            var w4 = DateEditor;

            initFormType(ContentCommentForm, [
                'CommentText', w0,
                'CommentLeft', w1,
                'CommentRight', w1,
                'TreeId', w1,
                'CommentLevel', w1,
                'ParentId', w2,
                'ContentId', w3,
                'UserId', w3,
                'InsertDate', w4,
                'InsertUserId', w1,
                'UpdateDate', w4,
                'UpdateUserId', w1,
                'IsActive', w1
            ]);
        }
    }
}