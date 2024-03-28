import { LookupEditor, ServiceLookupEditor, StringEditor, TextAreaEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EProjectType } from "../Web/Enums.EProjectType";

export interface ProjectForm {
    StudentId: LookupEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SemesterId: ServiceLookupEditor;
    Title: StringEditor;
    Description: TextAreaEditor;
    EType: EnumEditor;
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
            var w3 = TextAreaEditor;
            var w4 = EnumEditor;

            initFormType(ProjectForm, [
                'StudentId', w0,
                'CourseId', w1,
                'ClassId', w0,
                'SemesterId', w1,
                'Title', w2,
                'Description', w3,
                'EType', w4
            ]);
        }
    }
}

[EProjectType]; // referenced types