import { StringEditor, LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StudentForm {
    Prn: StringEditor;
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    UserId: LookupEditor;
    Description: StringEditor;
    StateId: IntegerEditor;
    DistrictId: IntegerEditor;
    TalukaId: IntegerEditor;
    Dob: DateEditor;
    SchoolId: IntegerEditor;
}

export class StudentForm extends PrefixedContext {
    static readonly formKey = 'Users.Student';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentForm.init)  {
            StudentForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(StudentForm, [
                'Prn', w0,
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'UserId', w1,
                'Description', w0,
                'StateId', w2,
                'DistrictId', w2,
                'TalukaId', w2,
                'Dob', w3,
                'SchoolId', w2
            ]);
        }
    }
}