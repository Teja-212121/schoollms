import { LookupEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionCourseForm {
    CourseId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
    QuestionId: LookupEditor;
}

export class QuestionCourseForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.QuestionCourse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionCourseForm.init)  {
            QuestionCourseForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;

            initFormType(QuestionCourseForm, [
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w1,
                'SubjectId', w0,
                'TopicId', w0,
                'QuestionId', w0
            ]);
        }
    }
}