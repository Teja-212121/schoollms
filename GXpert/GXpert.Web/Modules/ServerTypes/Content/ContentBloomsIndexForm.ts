import { ServiceLookupEditor, LookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentBloomsIndexForm {
    ContentId: ServiceLookupEditor;
    BloomsIndex: LookupEditor;
    Weightage: DecimalEditor;
}

export class ContentBloomsIndexForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentBloomsIndex';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentBloomsIndexForm.init)  {
            ContentBloomsIndexForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = DecimalEditor;

            initFormType(ContentBloomsIndexForm, [
                'ContentId', w0,
                'BloomsIndex', w1,
                'Weightage', w2
            ]);
        }
    }
}