import { StringEditor, IntegerEditor, LookupEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteForm {
    Name: StringEditor;
    Description: StringEditor;
    EType: IntegerEditor;
    Address: StringEditor;
    City: StringEditor;
    StateId: LookupEditor;
    DistrictId: LookupEditor;
    TalukaId: LookupEditor;
    LocationInfo: StringEditor;
    EstablishmentDate: DateEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
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
            var w1 = IntegerEditor;
            var w2 = LookupEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(InstituteForm, [
                'Name', w0,
                'Description', w0,
                'EType', w1,
                'Address', w0,
                'City', w0,
                'StateId', w2,
                'DistrictId', w2,
                'TalukaId', w2,
                'LocationInfo', w0,
                'EstablishmentDate', w3,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4,
                'PrincipalId', w1
            ]);
        }
    }
}