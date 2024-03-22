import { LookupEditor, ServiceLookupEditor, StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProjectForm {
    StudentId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    Title: StringEditor;
    Description: StringEditor;
    EType: IntegerEditor;
}

export class ProjectForm extends PrefixedContext {
    static readonly formKey = 'Masters.Project';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProjectForm.init)  {
            ProjectForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = IntegerEditor;

            initFormType(ProjectForm, [
                'StudentId', w0,
                'CourseId', w1,
                'ClassId', w0,
                'SemesterId', w1,
                'Title', w2,
                'Description', w2,
                'EType', w3
            ]);
        }
    }
}