import { LookupEditor, IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTeacherForm {
    TeacherId: LookupEditor;
    SchoolId: IntegerEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    Description: StringEditor;
    AcademicYearId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class InstituteTeacherForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTeacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTeacherForm.init)  {
            InstituteTeacherForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(InstituteTeacherForm, [
                'TeacherId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'SubjectId', w0,
                'Description', w2,
                'AcademicYearId', w0,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}