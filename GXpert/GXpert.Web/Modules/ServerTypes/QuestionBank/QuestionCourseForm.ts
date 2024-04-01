import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionCourseForm {
    QuestionId: LookupEditor;
    CourseId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
}

export class QuestionCourseForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.QuestionCourse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionCourseForm.init)  {
            QuestionCourseForm.init = true;

            var w0 = LookupEditor;

            initFormType(QuestionCourseForm, [
                'QuestionId', w0,
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'SubjectId', w0,
                'TopicId', w0
            ]);
        }
    }
}