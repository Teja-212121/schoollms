import { DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LiveSessionLogForm {
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    TeacherId: IntegerEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class LiveSessionLogForm extends PrefixedContext {
    static readonly formKey = 'LiveSessions.LiveSessionLog';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LiveSessionLogForm.init)  {
            LiveSessionLogForm.init = true;

            var w0 = DateEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;

            initFormType(LiveSessionLogForm, [
                'Date', w0,
                'StartTime', w0,
                'EndTime', w0,
                'TeacherId', w1,
                'ClassId', w1,
                'SubjectId', w1,
                'InsertDate', w0,
                'InsertUserId', w1,
                'UpdateDate', w0,
                'UpdateUserId', w1,
                'IsActive', w2
            ]);
        }
    }
}