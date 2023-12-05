import { ServiceLookupEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContentBloomsIndexForm {
    ContentId: ServiceLookupEditor;
    BloomsIndex: IntegerEditor;
    Weightage: DecimalEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ContentBloomsIndexForm extends PrefixedContext {
    static readonly formKey = 'Content.ContentBloomsIndex';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContentBloomsIndexForm.init)  {
            ContentBloomsIndexForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(ContentBloomsIndexForm, [
                'ContentId', w0,
                'BloomsIndex', w1,
                'Weightage', w2,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}