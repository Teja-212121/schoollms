import { LookupEditor, ServiceLookupEditor, DecimalEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicPerformanceForm {
    StudentId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    MarksObtained: DecimalEditor;
    OutOfMarks: DecimalEditor;
    Remarks: StringEditor;
    AcademicYearId: LookupEditor;
}

export class AcademicPerformanceForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicPerformance';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicPerformanceForm.init)  {
            AcademicPerformanceForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DecimalEditor;
            var w3 = StringEditor;

            initFormType(AcademicPerformanceForm, [
                'StudentId', w0,
                'CourseId', w1,
                'ClassId', w0,
                'SemesterId', w1,
                'MarksObtained', w2,
                'OutOfMarks', w2,
                'Remarks', w3,
                'AcademicYearId', w0
            ]);
        }
    }
}