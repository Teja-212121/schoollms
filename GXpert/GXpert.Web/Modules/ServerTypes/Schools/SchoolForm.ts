import { StringEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolForm {
    Name: StringEditor;
    Description: StringEditor;
    EType: StringEditor;
    Address: StringEditor;
    City: StringEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    LocationInfo: StringEditor;
    EstablishmentDate: DateEditor;
}

export class SchoolForm extends PrefixedContext {
    static readonly formKey = 'Schools.School';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolForm.init)  {
            SchoolForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(SchoolForm, [
                'Name', w0,
                'Description', w0,
                'EType', w0,
                'Address', w0,
                'City', w0,
                'StateId', w1,
                'DistrictId', w1,
                'TalukaId', w1,
                'LocationInfo', w0,
                'EstablishmentDate', w2
            ]);
        }
    }
}