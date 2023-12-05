import { ServiceLookupEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentTopicForm {
    ContentId: ServiceLookupEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    TopicId: IntegerEditor;
    MediumId: IntegerEditor;
    SortOrder: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ContentTopicForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentTopic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentTopicForm.init)  {
            ContentTopicForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(ContentTopicForm, [
                'ContentId', w0,
                'ClassId', w1,
                'SubjectId', w1,
                'TopicId', w1,
                'MediumId', w1,
                'SortOrder', w1,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}