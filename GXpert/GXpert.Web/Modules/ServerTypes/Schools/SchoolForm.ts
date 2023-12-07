import { StringEditor, EnumEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ESchoolType } from "../Web/Enums.ESchoolType";

export interface SchoolForm {
    Name: StringEditor;
    Description: StringEditor;
    EType: EnumEditor;
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
            var w1 = EnumEditor;
            var w2 = LookupEditor;
            var w3 = DateEditor;

            initFormType(SchoolForm, [
                'Name', w0,
                'Description', w0,
                'EType', w1,
                'Address', w0,
                'City', w0,
                'StateId', w2,
                'DistrictId', w2,
                'TalukaId', w2,
                'LocationInfo', w0,
                'EstablishmentDate', w3
            ]);
        }
    }
}

[ESchoolType]; // referenced types