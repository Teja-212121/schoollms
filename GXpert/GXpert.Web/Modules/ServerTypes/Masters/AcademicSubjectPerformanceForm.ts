import { LookupEditor, ServiceLookupEditor, EnumEditor, DecimalEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ETypeOfExam } from "../Web/Enums.ETypeOfExam";

export interface AcademicSubjectPerformanceForm {
    StudentId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    SubjectId: LookupEditor;
    ETypeOfExam: EnumEditor;
    MarksObtained: DecimalEditor;
    OutOfMarks: DecimalEditor;
    Remarks: StringEditor;
    AcademicYearId: LookupEditor;
}

export class AcademicSubjectPerformanceForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicSubjectPerformance';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicSubjectPerformanceForm.init)  {
            AcademicSubjectPerformanceForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = EnumEditor;
            var w3 = DecimalEditor;
            var w4 = StringEditor;

            initFormType(AcademicSubjectPerformanceForm, [
                'StudentId', w0,
                'CourseId', w1,
                'ClassId', w0,
                'SemesterId', w1,
                'SubjectId', w0,
                'ETypeOfExam', w2,
                'MarksObtained', w3,
                'OutOfMarks', w3,
                'Remarks', w4,
                'AcademicYearId', w0
            ]);
        }
    }
}

[ETypeOfExam]; // referenced types