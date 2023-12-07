import { ServiceLookupEditor, StringEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamSectionForm {
    ExamId: ServiceLookupEditor;
    Title: StringEditor;
    Instructions: StringEditor;
    DurationInSeconds: IntegerEditor;
    SortOrder: DecimalEditor;
    ParentId: ServiceLookupEditor;
    NumberOfQuestions: IntegerEditor;
    NumberOfMandatoryQuestions: IntegerEditor;
    SearchTags: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ExamSectionForm extends PrefixedContext {
    static readonly formKey = 'Exams.ExamSection';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamSectionForm.init)  {
            ExamSectionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = BooleanEditor;

            initFormType(ExamSectionForm, [
                'ExamId', w0,
                'Title', w1,
                'Instructions', w1,
                'DurationInSeconds', w2,
                'SortOrder', w3,
                'ParentId', w0,
                'NumberOfQuestions', w2,
                'NumberOfMandatoryQuestions', w2,
                'SearchTags', w1,
                'InsertDate', w4,
                'InsertUserId', w2,
                'UpdateDate', w4,
                'UpdateUserId', w2,
                'IsActive', w5
            ]);
        }
    }
}