import { StringEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListForm {
    Title: StringEditor;
    Description: StringEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    TeacherId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class PlayListForm extends PrefixedContext {
    static readonly formKey = 'Playlist.PlayList';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlayListForm.init)  {
            PlayListForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(PlayListForm, [
                'Title', w0,
                'Description', w0,
                'ClassId', w1,
                'SubjectId', w1,
                'TeacherId', w1,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}