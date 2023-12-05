import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolClassForm {
    ClassId: IntegerEditor;
    Division: StringEditor;
    MediumId: IntegerEditor;
    ClassTeacherId: IntegerEditor;
    Title: StringEditor;
    AcademicYearId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SchoolClassForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolClass';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolClassForm.init)  {
            SchoolClassForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(SchoolClassForm, [
                'ClassId', w0,
                'Division', w1,
                'MediumId', w0,
                'ClassTeacherId', w0,
                'Title', w1,
                'AcademicYearId', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}