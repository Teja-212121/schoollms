import { StringEditor, TextAreaEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    MediumId: ServiceLookupEditor;
    SubjectId: ServiceLookupEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
}

export class TopicForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Topic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TopicForm.init)  {
            TopicForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = ServiceLookupEditor;
            var w4 = DecimalEditor;

            initFormType(TopicForm, [
                'Title', w0,
                'Description', w1,
                'SortOrder', w2,
                'ClassId', w3,
                'MediumId', w3,
                'SubjectId', w3,
                'Weightage', w4,
                'Thumbnail', w0
            ]);
        }
    }
}