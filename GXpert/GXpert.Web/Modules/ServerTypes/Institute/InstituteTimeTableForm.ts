import { DateEditor, IntegerEditor, ServiceLookupEditor, LookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EInstituteTimeTableType } from "../Web/Enums.EInstituteTimeTableType";

export interface InstituteTimeTableForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    SchoolClassId: ServiceLookupEditor;
    TeacherId: LookupEditor;
    EType: EnumEditor;
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
            var w4 = EnumEditor;

            initFormType(InstituteTimeTableForm, [
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

[EInstituteTimeTableType]; // referenced types