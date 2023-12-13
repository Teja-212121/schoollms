import { StringEditor, LookupEditor, TextAreaEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlayListForm {
    Title: StringEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    TeacherId: LookupEditor;
    Description: TextAreaEditor;
    PlayListFilePath: StringEditor;
    PlayListVersion: IntegerEditor;
}

export class PlayListForm extends PrefixedContext {
    static readonly formKey = 'Playlist.PlayList';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlayListForm.init)  {
            PlayListForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = TextAreaEditor;
            var w3 = IntegerEditor;

            initFormType(PlayListForm, [
                'Title', w0,
                'ClassId', w1,
                'SubjectId', w1,
                'TeacherId', w1,
                'Description', w2,
                'PlayListFilePath', w0,
                'PlayListVersion', w3
            ]);
        }
    }
}