import { LookupEditor, ServiceLookupEditor, DecimalEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListContentForm {
    PlayListId: LookupEditor;
    ContentId: LookupEditor;
    ExamId: LookupEditor;
    LiveSessionId: LookupEditor;
    AssignmentId: LookupEditor;
    ModuleId: ServiceLookupEditor;
    SortOrder: DecimalEditor;
    EPublishStatus: IntegerEditor;
}

export class PlayListContentForm extends PrefixedContext {
    static readonly formKey = 'Playlist.PlayListContent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlayListContentForm.init)  {
            PlayListContentForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DecimalEditor;
            var w3 = IntegerEditor;

            initFormType(PlayListContentForm, [
                'PlayListId', w0,
                'ContentId', w0,
                'ExamId', w0,
                'LiveSessionId', w0,
                'AssignmentId', w0,
                'ModuleId', w1,
                'SortOrder', w2,
                'EPublishStatus', w3
            ]);
        }
    }
}