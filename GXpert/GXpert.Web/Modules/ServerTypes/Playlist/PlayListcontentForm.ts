import { IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListContentForm {
    PlayListId: IntegerEditor;
    ContentId: IntegerEditor;
    ExamId: IntegerEditor;
    LiveSessionId: IntegerEditor;
    AssignmentId: IntegerEditor;
    ModuleId: IntegerEditor;
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

            var w0 = IntegerEditor;
            var w1 = DecimalEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(PlayListContentForm, [
                'PlayListId', w0,
                'ContentId', w0,
                'ExamId', w0,
                'LiveSessionId', w0,
                'AssignmentId', w0,
                'ModuleId', w0,
                'SortOrder', w1,
                'EPublishStatus', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}