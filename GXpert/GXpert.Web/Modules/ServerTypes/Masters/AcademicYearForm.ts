import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicYearForm {
    Name: StringEditor;
    Description: StringEditor;
    StartDate: DateEditor;
    EndDate: DateEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AcademicYearForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicYear';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicYearForm.init)  {
            AcademicYearForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(AcademicYearForm, [
                'Name', w0,
                'Description', w0,
                'StartDate', w1,
                'EndDate', w1,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}