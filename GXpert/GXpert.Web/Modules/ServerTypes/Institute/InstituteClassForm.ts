import { LookupEditor, StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteClassForm {
    ClassId: LookupEditor;
    Division: StringEditor;
    MediumId: LookupEditor;
    ClassTeacherId: LookupEditor;
    Title: StringEditor;
    AcademicYearId: LookupEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
    InstituteId: IntegerEditor;
    DepartmentId: IntegerEditor;
    CourseId: IntegerEditor;
}

export class InstituteClassForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteClass';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteClassForm.init)  {
            InstituteClassForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;
            var w4 = BooleanEditor;

            initFormType(InstituteClassForm, [
                'ClassId', w0,
                'Division', w1,
                'MediumId', w0,
                'ClassTeacherId', w0,
                'Title', w1,
                'AcademicYearId', w0,
                'InsertDate', w2,
                'InsertUserId', w3,
                'UpdateDate', w2,
                'UpdateUserId', w3,
                'IsActive', w4,
                'InstituteId', w3,
                'DepartmentId', w3,
                'CourseId', w3
            ]);
        }
    }
}