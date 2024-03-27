import { LookupEditor, ServiceLookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteDivisionForm {
    InstituteId: LookupEditor;
    DepartmentId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    Title: StringEditor;
    Division: StringEditor;
    ClassTeacherId: LookupEditor;
    AcademicYearId: LookupEditor;
}

export class InstituteDivisionForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteDivision';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteDivisionForm.init)  {
            InstituteDivisionForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;

            initFormType(InstituteDivisionForm, [
                'InstituteId', w0,
                'DepartmentId', w0,
                'CourseId', w1,
                'ClassId', w0,
                'SemesterId', w1,
                'Title', w2,
                'Division', w2,
                'ClassTeacherId', w0,
                'AcademicYearId', w0
            ]);
        }
    }
}