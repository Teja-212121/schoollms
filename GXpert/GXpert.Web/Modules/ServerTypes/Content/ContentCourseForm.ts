import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentCourseForm {
    ContentId: LookupEditor;
    CourseId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
}

export class ContentCourseForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentCourse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentCourseForm.init)  {
            ContentCourseForm.init = true;

            var w0 = LookupEditor;

            initFormType(ContentCourseForm, [
                'ContentId', w0,
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'SubjectId', w0,
                'TopicId', w0
            ]);
        }
    }
}