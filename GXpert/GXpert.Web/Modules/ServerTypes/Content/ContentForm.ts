import { StringEditor, TextAreaEditor, EnumEditor, IntegerEditor, BooleanEditor, ImageUploadEditor, DecimalEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EContentState } from "../GExpert/Enums.EContentState";
import { EContentType } from "../Web/Enums.EContentType";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";

export interface ContentForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    EContentType: EnumEditor;
    EContentState: EnumEditor;
    EDifficultyLevel: EnumEditor;
    MediaVersion: IntegerEditor;
    EncodingStatus: StringEditor;
    MediaFile: StringEditor;
    HlsFile: StringEditor;
    FileKeyUrl: StringEditor;
    Iv: StringEditor;
    FriendlyToken: StringEditor;
    MediaInfo: StringEditor;
    SizeInBytes: StringEditor;
    DurationInSeconds: IntegerEditor;
    SearchTags: StringEditor;
    FilePath: StringEditor;
    FilePathFallBack1: StringEditor;
    FilePathFallBack2: StringEditor;
    DownloadFilePrimaryUrl: StringEditor;
    DownloadFileFallback1Url: StringEditor;
    DownloadFileFallback2Url: StringEditor;
    M3u8FilePrimaryUrl: StringEditor;
    M3u8FileFallback1Url: StringEditor;
    M3u8FileFallback2Url: StringEditor;
    AllowDownload: BooleanEditor;
    EnableComments: BooleanEditor;
    Views: IntegerEditor;
    IsFeatured: BooleanEditor;
    IsReviewed: BooleanEditor;
    IsListed: BooleanEditor;
    Md5sum: StringEditor;
    IsUserFeatured: BooleanEditor;
    ThumbNail: ImageUploadEditor;
    ThumbnailTime: DecimalEditor;
    Poster: ImageUploadEditor;
    Length: IntegerEditor;
    Size: IntegerEditor;
    NumberOfPages: IntegerEditor;
    LikesCount: IntegerEditor;
    DisLikesCount: IntegerEditor;
    HandRaiseCount: IntegerEditor;
    UserId: LookupEditor;
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
            var w4 = BooleanEditor;
            var w5 = ImageUploadEditor;
            var w6 = DecimalEditor;
            var w7 = LookupEditor;

            initFormType(ContentForm, [
                'Title', w0,
                'Description', w1,
                'EContentType', w2,
                'EContentState', w2,
                'EDifficultyLevel', w2,
                'MediaVersion', w3,
                'EncodingStatus', w0,
                'MediaFile', w0,
                'HlsFile', w0,
                'FileKeyUrl', w0,
                'Iv', w0,
                'FriendlyToken', w0,
                'MediaInfo', w0,
                'SizeInBytes', w0,
                'DurationInSeconds', w3,
                'SearchTags', w0,
                'FilePath', w0,
                'FilePathFallBack1', w0,
                'FilePathFallBack2', w0,
                'DownloadFilePrimaryUrl', w0,
                'DownloadFileFallback1Url', w0,
                'DownloadFileFallback2Url', w0,
                'M3u8FilePrimaryUrl', w0,
                'M3u8FileFallback1Url', w0,
                'M3u8FileFallback2Url', w0,
                'AllowDownload', w4,
                'EnableComments', w4,
                'Views', w3,
                'IsFeatured', w4,
                'IsReviewed', w4,
                'IsListed', w4,
                'Md5sum', w0,
                'IsUserFeatured', w4,
                'ThumbNail', w5,
                'ThumbnailTime', w6,
                'Poster', w5,
                'Length', w3,
                'Size', w3,
                'NumberOfPages', w3,
                'LikesCount', w3,
                'DisLikesCount', w3,
                'HandRaiseCount', w3,
                'UserId', w7
            ]);
        }
    }
}

[EContentType, EContentState, EDifficultyLevel]; // referenced types