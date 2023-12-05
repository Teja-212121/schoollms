import { StringEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentForm {
    Title: StringEditor;
    Description: StringEditor;
    File: StringEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AssignmentForm extends PrefixedContext {
    static readonly formKey = 'Exams.Assignment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentForm.init)  {
            AssignmentForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(AssignmentForm, [
                'Title', w0,
                'Description', w0,
                'File', w0,
                'ClassId', w1,
                'SubjectId', w1,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}