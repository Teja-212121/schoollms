import { DateEditor, IntegerEditor, ServiceLookupEditor, LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolTimeTableForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    SchoolClassId: ServiceLookupEditor;
    TeacherId: LookupEditor;
    EType: StringEditor;
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
            var w3 = LookupEditor;
            var w4 = StringEditor;

            initFormType(SchoolTimeTableForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'PeriodIndex', w1,
                'SchoolClassId', w2,
                'TeacherId', w3,
                'EType', w4
            ]);
        }
    }
}