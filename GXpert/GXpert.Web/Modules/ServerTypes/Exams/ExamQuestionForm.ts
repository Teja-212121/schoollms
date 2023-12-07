import { ServiceLookupEditor, StringEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamQuestionForm {
    ExamId: ServiceLookupEditor;
    ExamSectionId: ServiceLookupEditor;
    QuestionId: StringEditor;
    EDifficultyLevel: IntegerEditor;
    RightAnswer: StringEditor;
    Marks: DecimalEditor;
    SortOrder: DecimalEditor;
    ClassId: IntegerEditor;
    SubjectId: IntegerEditor;
    TopicId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ExamQuestionForm extends PrefixedContext {
    static readonly formKey = 'Exams.ExamQuestion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamQuestionForm.init)  {
            ExamQuestionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = BooleanEditor;

            initFormType(ExamQuestionForm, [
                'ExamId', w0,
                'ExamSectionId', w0,
                'QuestionId', w1,
                'EDifficultyLevel', w2,
                'RightAnswer', w1,
                'Marks', w3,
                'SortOrder', w3,
                'ClassId', w2,
                'SubjectId', w2,
                'TopicId', w2,
                'InsertDate', w4,
                'InsertUserId', w2,
                'UpdateDate', w4,
                'UpdateUserId', w2,
                'IsActive', w5
            ]);
        }
    }
}