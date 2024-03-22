import { DateEditor, IntegerEditor, ServiceLookupEditor, LookupEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTimeTableForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    SchoolClassId: ServiceLookupEditor;
    TeacherId: LookupEditor;
    EType: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class InstituteTimeTableForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTimeTable';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTimeTableForm.init)  {
            InstituteTimeTableForm.init = true;

            var w0 = DateEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = LookupEditor;
            var w4 = BooleanEditor;

            initFormType(InstituteTimeTableForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'PeriodIndex', w1,
                'SchoolClassId', w2,
                'TeacherId', w3,
                'EType', w1,
                'InsertDate', w0,
                'InsertUserId', w1,
                'UpdateDate', w0,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}