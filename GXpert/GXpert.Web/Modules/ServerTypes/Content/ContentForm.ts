import { StringEditor, TextAreaEditor, EnumEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EContentType } from "../Web/Enums.EContentType";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";

export interface ContentForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    FileKeyUrl: StringEditor;
    EContentType: EnumEditor;
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
    EDifficultyLevel: EnumEditor;
}

export class ContentForm extends PrefixedContext {
    static readonly formKey = 'Content.Content';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentForm.init)  {
            ContentForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = EnumEditor;
            var w3 = IntegerEditor;

            initFormType(ContentForm, [
                'Title', w0,
                'Description', w1,
                'FileKeyUrl', w0,
                'EContentType', w2,
                'Iv', w0,
                'FilePath', w0,
                'FilePathFallBack1', w0,
                'FilePathFallBack2', w0,
                'MediaInfo', w0,
                'ThumbNail', w0,
                'Poster', w0,
                'Length', w3,
                'Size', w3,
                'NumberOfPages', w3,
                'LikesCount', w3,
                'DisLikesCount', w3,
                'HandRaiseCount', w3,
                'SearchTags', w0,
                'EDifficultyLevel', w2
            ]);
        }
    }
}

[EContentType, EDifficultyLevel]; // referenced types