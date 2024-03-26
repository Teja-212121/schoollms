import { ServiceLookupEditor, StringEditor, IntegerEditor, DecimalEditor, ImageUploadEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicForm {
    CourseId: ServiceLookupEditor;
    ClassId: ServiceLookupEditor;
    SemesterId: ServiceLookupEditor;
    SubjectId: ServiceLookupEditor;
    Title: StringEditor;
    SortOrder: IntegerEditor;
    Weightage: DecimalEditor;
    Thumbnail: ImageUploadEditor;
    Description: TextAreaEditor;
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
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = ImageUploadEditor;
            var w5 = TextAreaEditor;

            initFormType(TopicForm, [
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'SubjectId', w0,
                'Title', w1,
                'SortOrder', w2,
                'Weightage', w3,
                'Thumbnail', w4,
                'Description', w5
            ]);
        }
    }
}