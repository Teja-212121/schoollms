import { StringEditor, IntegerEditor, DecimalEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamForm {
    Title: StringEditor;
    EExamType: IntegerEditor;
    EExamState: IntegerEditor;
    QuestionPaperPath: StringEditor;
    ModelAnswerPaperPath: StringEditor;
    ExamDuration: IntegerEditor;
    MaxMarks: DecimalEditor;
    NegativeMarks: DecimalEditor;
    EExamNavigation: IntegerEditor;
    ESectionNavigation: IntegerEditor;
    EQuestionNavigation: IntegerEditor;
    EResultType: IntegerEditor;
    EOptionDisplayType: IntegerEditor;
    HasNegativeMarketing: BooleanEditor;
    Instructions: StringEditor;
    SearchTags: StringEditor;
}

export class ExamForm extends PrefixedContext {
    static readonly formKey = 'Exams.Exam';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamForm.init)  {
            ExamForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = BooleanEditor;

            initFormType(ExamForm, [
                'Title', w0,
                'EExamType', w1,
                'EExamState', w1,
                'QuestionPaperPath', w0,
                'ModelAnswerPaperPath', w0,
                'ExamDuration', w1,
                'MaxMarks', w2,
                'NegativeMarks', w2,
                'EExamNavigation', w1,
                'ESectionNavigation', w1,
                'EQuestionNavigation', w1,
                'EResultType', w1,
                'EOptionDisplayType', w1,
                'HasNegativeMarketing', w3,
                'Instructions', w0,
                'SearchTags', w0
            ]);
        }
    }
}