import { ServiceLookupEditor, LookupEditor, StringEditor, IntegerEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BranchForm {
    InstituteId: ServiceLookupEditor;
    DepartmentId: LookupEditor;
    Title: StringEditor;
    BranchCode: IntegerEditor;
    Description: TextAreaEditor;
}

export class BranchForm extends PrefixedContext {
    static readonly formKey = 'Institute.Branch';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BranchForm.init)  {
            BranchForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;
            var w3 = IntegerEditor;
            var w4 = TextAreaEditor;

            initFormType(BranchForm, [
                'InstituteId', w0,
                'DepartmentId', w1,
                'Title', w2,
                'BranchCode', w3,
                'Description', w4
            ]);
        }
    }
}