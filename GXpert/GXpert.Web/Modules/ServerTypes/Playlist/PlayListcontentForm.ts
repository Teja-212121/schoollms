import { EnumEditor, LookupEditor, ServiceLookupEditor, DecimalEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EPlayListContentType } from "../Web/Enums.EPlayListContentType";

export interface PlayListContentForm {
    EContentType: EnumEditor;
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

            var w0 = EnumEditor;
            var w1 = LookupEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DecimalEditor;
            var w4 = IntegerEditor;

            initFormType(PlayListContentForm, [
                'EContentType', w0,
                'PlayListId', w1,
                'ContentId', w1,
                'ExamId', w1,
                'LiveSessionId', w1,
                'AssignmentId', w1,
                'ModuleId', w2,
                'SortOrder', w3,
                'EPublishStatus', w4
            ]);
        }
    }
}

[EPlayListContentType]; // referenced types