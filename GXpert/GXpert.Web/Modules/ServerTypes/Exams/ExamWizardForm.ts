import { ExamSectionEditor } from "@/Exams/ExamSection/ExamSectionEditor";
import { StringEditor, IntegerEditor, DecimalEditor, HtmlContentEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExamWizardForm {
    Title: StringEditor;
    EExamType: IntegerEditor;
    EExamState: IntegerEditor;
    QuestionPaperPath: StringEditor;
    ModelAnswerPaperPath: StringEditor;
    ExamDuration: IntegerEditor;
    MaxMarks: DecimalEditor;
    NegativeMarks: DecimalEditor;
    EResultType: IntegerEditor;
    Instructions: HtmlContentEditor;
    SearchTags: StringEditor;
    ExamSection: ExamSectionEditor;
    ExamQuestions: StringEditor;
}

export class ExamWizardForm extends PrefixedContext {
    static readonly formKey = 'Exams.ExamWizardForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamWizardForm.init)  {
            ExamWizardForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = HtmlContentEditor;
            var w4 = ExamSectionEditor;

            initFormType(ExamWizardForm, [
                'Title', w0,
                'EExamType', w1,
                'EExamState', w1,
                'QuestionPaperPath', w0,
                'ModelAnswerPaperPath', w0,
                'ExamDuration', w1,
                'MaxMarks', w2,
                'NegativeMarks', w2,
                'EResultType', w1,
                'Instructions', w3,
                'SearchTags', w0,
                'ExamSection', w4,
                'ExamQuestions', w0
            ]);
        }
    }
}