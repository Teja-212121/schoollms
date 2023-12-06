import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentForm {
    Title: StringEditor;
    Description: StringEditor;
    EContentType: IntegerEditor;
    FileKeyUrl: StringEditor;
    Iv: StringEditor;
    FilePath: StringEditor;
    FilePathFallBack1: StringEditor;
    FilePathFallBack2: StringEditor;
    MediaInfo: StringEditor;
    ThumbNail: StringEditor;
    Poster: StringEditor;
    Length: IntegerEditor;
    Size: IntegerEditor;
    NumberOfPages: IntegerEditor;
    LikesCount: IntegerEditor;
    DisLikesCount: IntegerEditor;
    HandRaiseCount: IntegerEditor;
    SearchTags: StringEditor;
    EDifficultyLevel: IntegerEditor;
}

export class ContentForm extends PrefixedContext {
    static readonly formKey = 'Content.Content';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentForm.init)  {
            ContentForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ContentForm, [
                'Title', w0,
                'Description', w0,
                'EContentType', w1,
                'FileKeyUrl', w0,
                'Iv', w0,
                'FilePath', w0,
                'FilePathFallBack1', w0,
                'FilePathFallBack2', w0,
                'MediaInfo', w0,
                'ThumbNail', w0,
                'Poster', w0,
                'Length', w1,
                'Size', w1,
                'NumberOfPages', w1,
                'LikesCount', w1,
                'DisLikesCount', w1,
                'HandRaiseCount', w1,
                'SearchTags', w0,
                'EDifficultyLevel', w1
            ]);
        }
    }
}