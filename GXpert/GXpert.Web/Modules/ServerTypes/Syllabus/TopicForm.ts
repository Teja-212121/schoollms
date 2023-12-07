import { StringEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicForm {
    Title: StringEditor;
    Description: StringEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    MediumId: ServiceLookupEditor;
    SubjectId: ServiceLookupEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class TopicForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Topic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TopicForm.init)  {
            TopicForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = BooleanEditor;

            initFormType(TopicForm, [
                'Title', w0,
                'Description', w0,
                'SortOrder', w1,
                'ClassId', w2,
                'MediumId', w2,
                'SubjectId', w2,
                'Weightage', w3,
                'Thumbnail', w0,
                'InsertDate', w4,
                'InsertUserId', w1,
                'UpdateDate', w4,
                'UpdateUserId', w1,
                'IsActive', w5
            ]);
        }
    }
}