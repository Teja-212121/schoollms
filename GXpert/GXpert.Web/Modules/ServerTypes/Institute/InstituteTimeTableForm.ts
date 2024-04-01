import { IntegerEditor, DateEditor, LookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EInstituteTimeTableType } from "../Web/Enums.EInstituteTimeTableType";
import { ETeacherAttendanceStatus } from "../Web/Enums.ETeacherAttendanceStatus";

export interface InstituteTimeTableForm {
    ClassRoomNo: IntegerEditor;
    Date: DateEditor;
    StartTime: DateEditor;
    EndTime: DateEditor;
    PeriodIndex: IntegerEditor;
    InstituteId: LookupEditor;
    DepartmentId: LookupEditor;
    BranchId: LookupEditor;
    InstituteDivisionId: LookupEditor;
    TeacherId: LookupEditor;
    EType: EnumEditor;
    TeacherAttendanceStatus: EnumEditor;
}

export class InstituteTimeTableForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTimeTable';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTimeTableForm.init)  {
            InstituteTimeTableForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = LookupEditor;
            var w3 = EnumEditor;

            initFormType(InstituteTimeTableForm, [
                'ClassRoomNo', w0,
                'Date', w1,
                'StartTime', w1,
                'EndTime', w1,
                'PeriodIndex', w0,
                'InstituteId', w2,
                'DepartmentId', w2,
                'BranchId', w2,
                'InstituteDivisionId', w2,
                'TeacherId', w2,
                'EType', w3,
                'TeacherAttendanceStatus', w3
            ]);
        }
    }
}

[EInstituteTimeTableType, ETeacherAttendanceStatus]; // referenced types