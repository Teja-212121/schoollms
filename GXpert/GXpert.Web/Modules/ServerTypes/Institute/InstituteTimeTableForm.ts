import { DateEditor, IntegerEditor, LookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EInstituteTimeTableType } from "../Web/Enums.EInstituteTimeTableType";

export interface InstituteTimeTableForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    InstituteClassesId: IntegerEditor;
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
            var w2 = LookupEditor;
            var w3 = EnumEditor;

            initFormType(InstituteTimeTableForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'PeriodIndex', w1,
                'InstituteClassesId', w1,
                'TeacherId', w2,
                'EType', w3
            ]);
        }
    }
}

[EInstituteTimeTableType]; // referenced types