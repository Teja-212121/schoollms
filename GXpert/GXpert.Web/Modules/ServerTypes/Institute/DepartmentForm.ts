import { HodDialog } from "@/Users/Hod/HodDialog";
import { ServiceLookupEditor, LookupEditor, TextAreaEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DepartmentForm {
    InstituteId: ServiceLookupEditor;
    HodId: LookupEditor;
    Title: TextAreaEditor;
    Description: StringEditor;
}

export class DepartmentForm extends PrefixedContext {
    static readonly formKey = 'Institute.Department';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DepartmentForm.init)  {
            DepartmentForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = TextAreaEditor;
            var w3 = StringEditor;

            initFormType(DepartmentForm, [
                'InstituteId', w0,
                'HodId', w1,
                'Title', w2,
                'Description', w3
            ]);
        }
    }
}

[HodDialog]; // referenced types