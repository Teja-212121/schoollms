import { StringEditor, LookupEditor, DateEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface HodForm {
    Name: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    UserId: LookupEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    Dob: DateEditor;
    InstituteId: ServiceLookupEditor;
}

export class HodForm extends PrefixedContext {
    static readonly formKey = 'Users.Hod';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!HodForm.init)  {
            HodForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;
            var w3 = ServiceLookupEditor;

            initFormType(HodForm, [
                'Name', w0,
                'Email', w0,
                'Mobile', w0,
                'UserId', w1,
                'StateId', w1,
                'DistrictId', w1,
                'TalukaId', w1,
                'Dob', w2,
                'InstituteId', w3
            ]);
        }
    }
}