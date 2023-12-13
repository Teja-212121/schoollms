import { StringEditor, TextAreaEditor, EnumEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ESchoolType } from "../Web/Enums.ESchoolType";

export interface SchoolForm {
    Name: StringEditor;
    Description: TextAreaEditor;
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
            var w1 = TextAreaEditor;
            var w2 = EnumEditor;
            var w3 = LookupEditor;
            var w4 = DateEditor;

            initFormType(SchoolForm, [
                'Name', w0,
                'Description', w1,
                'EType', w2,
                'Address', w0,
                'City', w0,
                'StateId', w3,
                'DistrictId', w3,
                'TalukaId', w3,
                'LocationInfo', w0,
                'EstablishmentDate', w4
            ]);
        }
    }
}

[ESchoolType]; // referenced types