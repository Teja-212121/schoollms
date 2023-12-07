import { ServiceLookupEditor, LookupEditor, EnumEditor, StringEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";

export interface ExamQuestionForm {
    ExamId: ServiceLookupEditor;
    ExamSectionId: ServiceLookupEditor;
    QuestionId: LookupEditor;
    EDifficultyLevel: EnumEditor;
    RightAnswer: StringEditor;
    Marks: DecimalEditor;
    SortOrder: DecimalEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    TopicId: LookupEditor;
}

export class ExamQuestionForm extends PrefixedContext {
    static readonly formKey = 'Exams.ExamQuestion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamQuestionForm.init)  {
            ExamQuestionForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = EnumEditor;
            var w3 = StringEditor;
            var w4 = DecimalEditor;

            initFormType(ExamQuestionForm, [
                'ExamId', w0,
                'ExamSectionId', w0,
                'QuestionId', w1,
                'EDifficultyLevel', w2,
                'RightAnswer', w3,
                'Marks', w4,
                'SortOrder', w4,
                'ClassId', w1,
                'SubjectId', w1,
                'TopicId', w1
            ]);
        }
    }
}

[EDifficultyLevel]; // referenced types