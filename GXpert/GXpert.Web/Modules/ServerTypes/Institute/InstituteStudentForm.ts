import { LookupEditor, IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteStudentForm {
    StudentId: LookupEditor;
    SchoolId: IntegerEditor;
    ClassId: LookupEditor;
    Division: StringEditor;
    RollNumber: StringEditor;
    Description: StringEditor;
    AcademicYearId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class InstituteStudentForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteStudent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteStudentForm.init)  {
            InstituteStudentForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(InstituteStudentForm, [
                'StudentId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'Division', w2,
                'RollNumber', w2,
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