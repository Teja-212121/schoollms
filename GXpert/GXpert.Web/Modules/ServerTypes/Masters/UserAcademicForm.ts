import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UserAcademicForm {
    StudentId: LookupEditor;
    AcademicYearId: LookupEditor;
    Title: StringEditor;
    Description: TextAreaEditor;
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
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;
            var w4 = IntegerEditor;

            initFormType(UserAcademicForm, [
                'StudentId', w0,
                'AcademicYearId', w0,
                'Title', w1,
                'Description', w2,
                'IsVerify', w3,
                'VerifyBy', w4
            ]);
        }
    }
}