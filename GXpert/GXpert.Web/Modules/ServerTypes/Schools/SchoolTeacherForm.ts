import { IntegerEditor, ServiceLookupEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolTeacherForm {
    TeacherId: IntegerEditor;
    SchoolId: ServiceLookupEditor;
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
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(SchoolTeacherForm, [
                'TeacherId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'SubjectId', w0,
                'Description', w2,
                'AcademicYearId', w0,
                'InsertDate', w3,
                'InsertUserId', w0,
                'UpdateDate', w3,
                'UpdateUserId', w0,
                'IsActive', w4
            ]);
        }
    }
}