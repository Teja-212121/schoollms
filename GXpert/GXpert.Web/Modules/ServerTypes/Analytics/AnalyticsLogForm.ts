import { IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AnalyticsLogForm {
    ContentId: IntegerEditor;
    ActivationId: IntegerEditor;
    StudentId: IntegerEditor;
    StartDatetime: DateEditor;
    EndDateTime: DateEditor;
    TimeSpent: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AnalyticsLogForm extends PrefixedContext {
    static readonly formKey = 'Analytics.AnalyticsLog';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AnalyticsLogForm.init)  {
            AnalyticsLogForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = BooleanEditor;

            initFormType(AnalyticsLogForm, [
                'ContentId', w0,
                'ActivationId', w0,
                'StudentId', w0,
                'StartDatetime', w1,
                'EndDateTime', w1,
                'TimeSpent', w0,
                'InsertDate', w1,
                'InsertUserId', w0,
                'UpdateDate', w1,
                'UpdateUserId', w0,
                'IsActive', w2
            ]);
        }
    }
}