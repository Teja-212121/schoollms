import { LookupEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentCourseForm {
    ContentId: LookupEditor;
    CourseId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: LookupEditor;
    UserId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ContentCourseForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentCourse';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentCourseForm.init)  {
            ContentCourseForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(ContentCourseForm, [
                'ContentId', w0,
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'UserId', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w2
            ]);
        }
    }
}