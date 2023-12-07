import { LookupEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AnalyticsLogForm {
    ContentId: LookupEditor;
    ActivationId: LookupEditor;
    StudentId: LookupEditor;
    StartDatetime: DateEditor;
    EndDateTime: DateEditor;
    TimeSpent: IntegerEditor;
}

export class AnalyticsLogForm extends PrefixedContext {
    static readonly formKey = 'Analytics.AnalyticsLog';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AnalyticsLogForm.init)  {
            AnalyticsLogForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(AnalyticsLogForm, [
                'ContentId', w0,
                'ActivationId', w0,
                'StudentId', w0,
                'StartDatetime', w1,
                'EndDateTime', w1,
                'TimeSpent', w2
            ]);
        }
    }
}