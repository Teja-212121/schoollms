import { StringEditor, LookupEditor, DateEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TeacherForm {
    Prn: StringEditor;
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    UserId: LookupEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    Dob: DateEditor;
    SchoolId: LookupEditor;
    Description: TextAreaEditor;
}

export class TeacherForm extends PrefixedContext {
    static readonly formKey = 'Users.Teacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TeacherForm.init)  {
            TeacherForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;
            var w3 = TextAreaEditor;

            initFormType(TeacherForm, [
                'Prn', w0,
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'UserId', w1,
                'StateId', w1,
                'DistrictId', w1,
                'TalukaId', w1,
                'Dob', w2,
                'SchoolId', w1,
                'Description', w3
            ]);
        }
    }
}