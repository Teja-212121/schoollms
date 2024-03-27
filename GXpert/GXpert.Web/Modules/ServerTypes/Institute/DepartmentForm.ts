import { StringEditor, ServiceLookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DepartmentForm {
    Title: StringEditor;
    InstituteId: ServiceLookupEditor;
    HodId: IntegerEditor;
    Description: StringEditor;
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
            var w2 = IntegerEditor;

            initFormType(DepartmentForm, [
                'Title', w0,
                'InstituteId', w1,
                'HodId', w2,
                'Description', w0
            ]);
        }
    }
}