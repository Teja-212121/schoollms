import { StringEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ELiveProvider } from "../Web/Enums.ELiveProvider";

export interface LiveSessionForm {
    MeetingId: StringEditor;
    Title: StringEditor;
    LiveProvider: EnumEditor;
    Password: StringEditor;
    Secret: StringEditor;
    LiveAdditionalInfo: StringEditor;
    SearchTags: StringEditor;
}

export class LiveSessionForm extends PrefixedContext {
    static readonly formKey = 'LiveSessions.LiveSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LiveSessionForm.init)  {
            LiveSessionForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;

            initFormType(LiveSessionForm, [
                'MeetingId', w0,
                'Title', w0,
                'LiveProvider', w1,
                'Password', w0,
                'Secret', w0,
                'LiveAdditionalInfo', w0,
                'SearchTags', w0
            ]);
        }
    }
}

[ELiveProvider]; // referenced types