import { ServiceLookupEditor, StringEditor, TextAreaEditor, IntegerEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicForm {
    CourseId: ServiceLookupEditor;
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    SemesterId: ServiceLookupEditor;
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

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;

            initFormType(TopicForm, [
                'CourseId', w0,
                'Title', w1,
                'Description', w2,
                'SortOrder', w3,
                'ClassId', w0,
                'SemesterId', w0,
                'SubjectId', w0,
                'Weightage', w4,
                'Thumbnail', w1
            ]);
        }
    }
}