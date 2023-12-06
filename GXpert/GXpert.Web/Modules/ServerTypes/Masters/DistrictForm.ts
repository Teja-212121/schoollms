import { StringEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DistrictForm {
    Title: StringEditor;
    StateId: ServiceLookupEditor;
    ShortName: StringEditor;
}

export class DistrictForm extends PrefixedContext {
    static readonly formKey = 'Masters.District';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DistrictForm.init)  {
            DistrictForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;

            initFormType(DistrictForm, [
                'Title', w0,
                'StateId', w1,
                'ShortName', w0
            ]);
        }
    }
}