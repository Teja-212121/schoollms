import { HodDialog } from "@/Users/Hod/HodDialog";
import { StringEditor, ServiceLookupEditor, LookupEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DepartmentForm {
    Title: StringEditor;
    InstituteId: ServiceLookupEditor;
    HodId: LookupEditor;
    Description: TextAreaEditor;
}

export class DepartmentForm extends PrefixedContext {
    static readonly formKey = 'Institute.Department';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DepartmentForm.init)  {
            DepartmentForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;
            var w3 = TextAreaEditor;

            initFormType(DepartmentForm, [
                'Title', w0,
                'InstituteId', w1,
                'HodId', w2,
                'Description', w3
            ]);
        }
    }
}

[HodDialog]; // referenced types