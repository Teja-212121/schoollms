import { EnumEditor, LookupEditor, ServiceLookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamStatus } from "../Web/Enums.EExamStatus";
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
    EPublishStatus: EnumEditor;
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

            initFormType(PlayListContentForm, [
                'EContentType', w0,
                'PlayListId', w1,
                'ContentId', w1,
                'ExamId', w1,
                'LiveSessionId', w1,
                'AssignmentId', w1,
                'ModuleId', w2,
                'SortOrder', w3,
                'EPublishStatus', w0
            ]);
        }
    }
}

[EPlayListContentType, EExamStatus]; // referenced types