import { ServiceLookupEditor, LookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentTopicForm {
    ContentId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
    MediumId: LookupEditor;
    SortOrder: IntegerEditor;
}

export class ContentTopicForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentTopic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentTopicForm.init)  {
            ContentTopicForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;

            initFormType(ContentTopicForm, [
                'ContentId', w0,
                'ClassId', w1,
                'SubjectId', w1,
                'TopicId', w1,
                'MediumId', w1,
                'SortOrder', w2
            ]);
        }
    }
}