import { DateEditor, IntegerEditor, ServiceLookupEditor, StringEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolTimeTableForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    SchoolClassId: ServiceLookupEditor;
    TeacherId: IntegerEditor;
    EType: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SchoolTimeTableForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolTimeTable';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolTimeTableForm.init)  {
            SchoolTimeTableForm.init = true;

            var w0 = DateEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = StringEditor;
            var w4 = BooleanEditor;

            initFormType(SchoolTimeTableForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'PeriodIndex', w1,
                'SchoolClassId', w2,
                'TeacherId', w1,
                'EType', w3,
                'InsertDate', w0,
                'InsertUserId', w1,
                'UpdateDate', w0,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}