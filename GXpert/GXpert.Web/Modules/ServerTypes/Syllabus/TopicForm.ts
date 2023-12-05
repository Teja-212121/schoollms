import { StringEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicForm {
    Title: StringEditor;
    Description: StringEditor;
    SortOrder: IntegerEditor;
    ClassId: IntegerEditor;
    MediumId: IntegerEditor;
    SubjectId: IntegerEditor;
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
            var w2 = DecimalEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(TopicForm, [
                'Title', w0,
                'Description', w0,
                'SortOrder', w1,
                'ClassId', w1,
                'MediumId', w1,
                'SubjectId', w1,
                'Weightage', w2,
                'Thumbnail', w0,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}