import { ServiceLookupEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListcontentForm {
    PlayListId: ServiceLookupEditor;
    ContentId: IntegerEditor;
    ExamId: IntegerEditor;
    LiveSessionId: IntegerEditor;
    AssignmentId: IntegerEditor;
    ModuleId: ServiceLookupEditor;
    SortOrder: DecimalEditor;
    EPublishStatus: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class PlayListcontentForm extends PrefixedContext {
    static readonly formKey = 'Playlist.PlayListcontent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlayListcontentForm.init)  {
            PlayListcontentForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(PlayListcontentForm, [
                'PlayListId', w0,
                'ContentId', w1,
                'ExamId', w1,
                'LiveSessionId', w1,
                'AssignmentId', w1,
                'ModuleId', w0,
                'SortOrder', w2,
                'EPublishStatus', w1,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}