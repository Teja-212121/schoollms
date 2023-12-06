import { ServiceLookupEditor, DecimalEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListContentForm {
    PlayListId: ServiceLookupEditor;
    ContentId: ServiceLookupEditor;
    ExamId: ServiceLookupEditor;
    LiveSessionId: ServiceLookupEditor;
    AssignmentId: ServiceLookupEditor;
    ModuleId: ServiceLookupEditor;
    SortOrder: DecimalEditor;
    EPublishStatus: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class PlayListContentForm extends PrefixedContext {
    static readonly formKey = 'Playlist.PlayListContent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlayListContentForm.init)  {
            PlayListContentForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = DecimalEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(PlayListContentForm, [
                'PlayListId', w0,
                'ContentId', w0,
                'ExamId', w0,
                'LiveSessionId', w0,
                'AssignmentId', w0,
                'ModuleId', w0,
                'SortOrder', w1,
                'EPublishStatus', w2,
                'InsertDate', w3,
                'InsertUserId', w2,
                'UpdateDate', w3,
                'UpdateUserId', w2,
                'IsActive', w4
            ]);
        }
    }
}