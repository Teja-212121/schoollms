import { StringEditor, EnumEditor, LookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamStatus } from "../Web/Enums.EExamStatus";
import { EPlayListContentType } from "../Web/Enums.EPlayListContentType";

export interface ContentAssignToPlayListcontentForm {
    RowIds: StringEditor;
    EContentType: EnumEditor;
    PlayListId: LookupEditor;
    ContentId: LookupEditor;
    ExamId: LookupEditor;
    LiveSessionId: LookupEditor;
    AssignmentId: LookupEditor;
    ModuleId: LookupEditor;
    EPublishStatus: EnumEditor;
    SortOrder: DecimalEditor;
}

export class ContentAssignToPlayListcontentForm extends PrefixedContext {
    static readonly formKey = 'Playlist.ContentAssignToPlayListcontentForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentAssignToPlayListcontentForm.init)  {
            ContentAssignToPlayListcontentForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = LookupEditor;
            var w3 = DecimalEditor;

            initFormType(ContentAssignToPlayListcontentForm, [
                'RowIds', w0,
                'EContentType', w1,
                'PlayListId', w2,
                'ContentId', w2,
                'ExamId', w2,
                'LiveSessionId', w2,
                'AssignmentId', w2,
                'ModuleId', w2,
                'EPublishStatus', w1,
                'SortOrder', w3
            ]);
        }
    }
}

[EPlayListContentType, EExamStatus]; // referenced types