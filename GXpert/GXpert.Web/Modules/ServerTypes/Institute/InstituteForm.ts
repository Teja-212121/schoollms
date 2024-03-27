import { StringEditor, TextAreaEditor, EnumEditor, LookupEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EInstituteType } from "../Web/Enums.EInstituteType";

export interface InstituteForm {
    Name: StringEditor;
    Description: TextAreaEditor;
    EType: EnumEditor;
    Address: StringEditor;
    City: StringEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    LocationInfo: TextAreaEditor;
    EstablishmentDate: DateEditor;
    PrincipalId: IntegerEditor;
}

export class InstituteForm extends PrefixedContext {
    static readonly formKey = 'Institute.Institute';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteForm.init)  {
            InstituteForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = EnumEditor;
            var w3 = LookupEditor;
            var w4 = DateEditor;
            var w5 = IntegerEditor;

            initFormType(InstituteForm, [
                'Name', w0,
                'Description', w1,
                'EType', w2,
                'Address', w0,
                'City', w0,
                'StateId', w3,
                'DistrictId', w3,
                'TalukaId', w3,
                'LocationInfo', w1,
                'EstablishmentDate', w4,
                'PrincipalId', w5
            ]);
        }
    }
}

[EInstituteType]; // referenced types