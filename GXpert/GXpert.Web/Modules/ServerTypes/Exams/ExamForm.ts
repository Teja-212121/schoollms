import { ExamSectionEditor } from "@/Exams/ExamSection/ExamSectionEditor";
import { StringEditor, EnumEditor, ImageUploadEditor, IntegerEditor, DecimalEditor, BooleanEditor, HtmlContentEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamState } from "../Web/Enums.EExamState";
import { EExamTypes } from "../Web/Enums.EExamTypes";
import { EOptionDisplayTypes } from "../Web/Enums.EOptionDisplayTypes";
import { EQuestionNavigation } from "../Web/Enums.EQuestionNavigation";
import { EResultTypes } from "../Web/Enums.EResultTypes";

export interface ExamForm {
    Title: StringEditor;
    EExamType: EnumEditor;
    EExamState: EnumEditor;
    QuestionPaperPath: ImageUploadEditor;
    ModelAnswerPaperPath: ImageUploadEditor;
    ExamDuration: IntegerEditor;
    MaxMarks: DecimalEditor;
    NegativeMarks: DecimalEditor;
    EExamNavigation: EnumEditor;
    ESectionNavigation: EnumEditor;
    EQuestionNavigation: EnumEditor;
    EResultType: EnumEditor;
    EOptionDisplayType: EnumEditor;
    HasNegativeMarketing: BooleanEditor;
    Instructions: HtmlContentEditor;
    SearchTags: StringEditor;
    ExamSection: ExamSectionEditor;
}

export class ExamForm extends PrefixedContext {
    static readonly formKey = 'Exams.Exam';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamForm.init)  {
            ExamForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = ImageUploadEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = BooleanEditor;
            var w6 = HtmlContentEditor;
            var w7 = ExamSectionEditor;

            initFormType(ExamForm, [
                'Title', w0,
                'EExamType', w1,
                'EExamState', w1,
                'QuestionPaperPath', w2,
                'ModelAnswerPaperPath', w2,
                'ExamDuration', w3,
                'MaxMarks', w4,
                'NegativeMarks', w4,
                'EExamNavigation', w1,
                'ESectionNavigation', w1,
                'EQuestionNavigation', w1,
                'EResultType', w1,
                'EOptionDisplayType', w1,
                'HasNegativeMarketing', w5,
                'Instructions', w6,
                'SearchTags', w0,
                'ExamSection', w7
            ]);
        }
    }
}

[EExamTypes, EExamState, EQuestionNavigation, EResultTypes, EOptionDisplayTypes]; // referenced types