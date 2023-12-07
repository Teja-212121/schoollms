import { StringEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TalukaForm {
    Title: StringEditor;
    StateId: ServiceLookupEditor;
    DistrictId: ServiceLookupEditor;
    ShortName: StringEditor;
}

export class TalukaForm extends PrefixedContext {
    static readonly formKey = 'Masters.Taluka';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TalukaForm.init)  {
            TalukaForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;

            initFormType(TalukaForm, [
                'Title', w0,
                'StateId', w1,
                'DistrictId', w1,
                'ShortName', w0
            ]);
        }
    }
}