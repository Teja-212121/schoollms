import { StringEditor, DateEditor, EnumEditor, LookupEditor, ServiceLookupEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EGender } from "../Web/Enums.EGender";

export interface StudentForm {
    Prn: StringEditor;
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    Dob: DateEditor;
    Gender: EnumEditor;
    UserId: LookupEditor;
    InstituteId: LookupEditor;
    DivisionId: LookupEditor;
    DepartmentId: LookupEditor;
    BranchId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    CurrentAcademicYearId: LookupEditor;
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
            var w2 = EnumEditor;
            var w3 = LookupEditor;
            var w4 = ServiceLookupEditor;
            var w5 = TextAreaEditor;

            initFormType(StudentForm, [
                'Prn', w0,
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'Dob', w1,
                'Gender', w2,
                'UserId', w3,
                'InstituteId', w3,
                'DivisionId', w3,
                'DepartmentId', w3,
                'BranchId', w3,
                'CourseId', w4,
                'ClassId', w3,
                'SemesterId', w4,
                'CurrentAcademicYearId', w3,
                'AddressLine1', w0,
                'AddressLine2', w0,
                'StateId', w3,
                'DistrictId', w3,
                'TalukaId', w3,
                'Description', w5
            ]);
        }
    }
}

[EGender]; // referenced types