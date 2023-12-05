import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolStudentForm {
    StudentId: IntegerEditor;
    SchoolId: IntegerEditor;
    ClassId: IntegerEditor;
    Division: StringEditor;
    RollNumber: StringEditor;
    Description: StringEditor;
    AcademicYearId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SchoolStudentForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolStudent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolStudentForm.init)  {
            SchoolStudentForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(SchoolStudentForm, [
                'StudentId', w0,
                'SchoolId', w0,
                'ClassId', w0,
                'Division', w1,
                'RollNumber', w1,
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