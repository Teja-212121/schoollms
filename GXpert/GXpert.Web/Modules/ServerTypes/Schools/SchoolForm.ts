import { StringEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolForm {
    Name: StringEditor;
    Description: StringEditor;
    EType: StringEditor;
    Address: StringEditor;
    City: StringEditor;
    StateId: IntegerEditor;
    DistrictId: IntegerEditor;
    TalukaId: IntegerEditor;
    LocationInfo: StringEditor;
    EstablishmentDate: DateEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SchoolForm extends PrefixedContext {
    static readonly formKey = 'Schools.School';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolForm.init)  {
            SchoolForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

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
                'EstablishmentDate', w2,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}