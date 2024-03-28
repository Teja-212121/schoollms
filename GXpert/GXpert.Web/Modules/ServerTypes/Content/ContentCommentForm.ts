import { StringEditor, IntegerEditor, ServiceLookupEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentCommentForm {
    CommentText: StringEditor;
    CommentLeft: IntegerEditor;
    CommentRight: IntegerEditor;
    TreeId: IntegerEditor;
    CommentLevel: IntegerEditor;
    ParentId: ServiceLookupEditor;
    ContentId: LookupEditor;
    UserId: LookupEditor;
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

            initFormType(ContentCommentForm, [
                'CommentText', w0,
                'CommentLeft', w1,
                'CommentRight', w1,
                'TreeId', w1,
                'CommentLevel', w1,
                'ParentId', w2,
                'ContentId', w3,
                'UserId', w3
            ]);
        }
    }
}