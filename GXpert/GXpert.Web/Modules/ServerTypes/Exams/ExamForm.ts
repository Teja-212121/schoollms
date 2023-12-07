import { StringEditor, EnumEditor, IntegerEditor, DecimalEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamState } from "../Web/Enums.EExamState";
import { EExamTypes } from "../Web/Enums.EExamTypes";
import { EOptionDisplayTypes } from "../Web/Enums.EOptionDisplayTypes";
import { EQuestionNavigation } from "../Web/Enums.EQuestionNavigation";
import { EResultTypes } from "../Web/Enums.EResultTypes";

export interface ExamForm {
    Title: StringEditor;
    EExamType: EnumEditor;
    EExamState: EnumEditor;
    QuestionPaperPath: StringEditor;
    ModelAnswerPaperPath: StringEditor;
    ExamDuration: IntegerEditor;
    MaxMarks: DecimalEditor;
    NegativeMarks: DecimalEditor;
    EExamNavigation: EnumEditor;
    ESectionNavigation: EnumEditor;
    EQuestionNavigation: EnumEditor;
    EResultType: EnumEditor;
    EOptionDisplayType: EnumEditor;
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
            var w1 = EnumEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = BooleanEditor;

            initFormType(ExamForm, [
                'Title', w0,
                'EExamType', w1,
                'EExamState', w1,
                'QuestionPaperPath', w0,
                'ModelAnswerPaperPath', w0,
                'ExamDuration', w2,
                'MaxMarks', w3,
                'NegativeMarks', w3,
                'EExamNavigation', w1,
                'ESectionNavigation', w1,
                'EQuestionNavigation', w1,
                'EResultType', w1,
                'EOptionDisplayType', w1,
                'HasNegativeMarketing', w4,
                'Instructions', w0,
                'SearchTags', w0
            ]);
        }
    }
}

[EExamTypes, EExamState, EQuestionNavigation, EResultTypes, EOptionDisplayTypes]; // referenced types