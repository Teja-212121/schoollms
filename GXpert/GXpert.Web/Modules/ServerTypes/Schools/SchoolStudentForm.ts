import { IntegerEditor, ServiceLookupEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolStudentForm {
    StudentId: IntegerEditor;
    SchoolId: ServiceLookupEditor;
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
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(SchoolStudentForm, [
                'StudentId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'Division', w2,
                'RollNumber', w2,
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