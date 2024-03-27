import { StringEditor, DateEditor, LookupEditor, ServiceLookupEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StudentForm {
    Prn: StringEditor;
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    Dob: DateEditor;
    Gender: StringEditor;
    UserId: LookupEditor;
    InstituteId: LookupEditor;
    DivisionId: LookupEditor;
    DepartmentId: LookupEditor;
    BranchId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    AddressLine1: StringEditor;
    AddressLine2: StringEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    Description: TextAreaEditor;
}

export class StudentForm extends PrefixedContext {
    static readonly formKey = 'Users.Student';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentForm.init)  {
            StudentForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = LookupEditor;
            var w3 = ServiceLookupEditor;
            var w4 = TextAreaEditor;

            initFormType(StudentForm, [
                'Prn', w0,
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'Dob', w1,
                'Gender', w0,
                'UserId', w2,
                'InstituteId', w2,
                'DivisionId', w2,
                'DepartmentId', w2,
                'BranchId', w2,
                'CourseId', w3,
                'ClassId', w2,
                'SemesterId', w3,
                'AddressLine1', w0,
                'AddressLine2', w0,
                'StateId', w2,
                'DistrictId', w2,
                'TalukaId', w2,
                'Description', w4
            ]);
        }
    }
}