import { StringEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PrincipalForm {
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    UserId: LookupEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    Dob: DateEditor;
}

export class PrincipalForm extends PrefixedContext {
    static readonly formKey = 'Users.Principal';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PrincipalForm.init)  {
            PrincipalForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(PrincipalForm, [
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'UserId', w1,
                'StateId', w1,
                'DistrictId', w1,
                'TalukaId', w1,
                'Dob', w2
            ]);
        }
    }
}