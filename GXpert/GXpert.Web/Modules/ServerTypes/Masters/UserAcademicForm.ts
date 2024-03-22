import { LookupEditor, StringEditor, BooleanEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UserAcademicForm {
    StudentId: LookupEditor;
    AcademicYearId: LookupEditor;
    Title: StringEditor;
    Description: StringEditor;
    IsVerify: BooleanEditor;
    VerifyBy: IntegerEditor;
}

export class UserAcademicForm extends PrefixedContext {
    static readonly formKey = 'Masters.UserAcademic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UserAcademicForm.init)  {
            UserAcademicForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;
            var w3 = IntegerEditor;

            initFormType(UserAcademicForm, [
                'StudentId', w0,
                'AcademicYearId', w0,
                'Title', w1,
                'Description', w1,
                'IsVerify', w2,
                'VerifyBy', w3
            ]);
        }
    }
}