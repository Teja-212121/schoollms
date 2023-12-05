import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolTeacherForm {
    TeacherId: IntegerEditor;
    SchoolId: IntegerEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    Description: StringEditor;
    AcademicYearId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SchoolTeacherForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolTeacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolTeacherForm.init)  {
            SchoolTeacherForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(SchoolTeacherForm, [
                'TeacherId', w0,
                'SchoolId', w0,
                'ClassId', w0,
                'SubjectId', w0,
                'Description', w1,
                'AcademicYearId', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}