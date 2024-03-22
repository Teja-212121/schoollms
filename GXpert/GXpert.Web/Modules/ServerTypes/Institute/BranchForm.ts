import { StringEditor, ServiceLookupEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BranchForm {
    Title: StringEditor;
    InstituteId: ServiceLookupEditor;
    DepartmentId: LookupEditor;
    Description: StringEditor;
}

export class BranchForm extends PrefixedContext {
    static readonly formKey = 'Institute.Branch';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BranchForm.init)  {
            BranchForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;

            initFormType(BranchForm, [
                'Title', w0,
                'InstituteId', w1,
                'DepartmentId', w2,
                'Description', w0
            ]);
        }
    }
}