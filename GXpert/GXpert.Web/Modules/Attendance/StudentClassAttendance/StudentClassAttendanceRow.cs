using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("StudentClassAttendance")]
[DisplayName("Student Class Attendance"), InstanceName("Student Class Attendance")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
[LookupScript("Attendance.Student Class Attendance")]
public sealed class StudentClassAttendanceRow : LoggingRow<StudentClassAttendanceRow.RowFields>, IIdRow
{
    const string jInstituteTimeTable = nameof(jInstituteTimeTable);
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Institute Time Table"), NotNull, ForeignKey(typeof(Institute.InstituteTimeTableRow)), LeftJoin(jInstituteTimeTable)]
    [ServiceLookupEditor(typeof(Institute.InstituteTimeTableRow), Service = "Institute/InstituteTimeTable/List")]
    public int? InstituteTimeTableId { get => fields.InstituteTimeTableId[this]; set => fields.InstituteTimeTableId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor(typeof(Users.StudentRow))]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Attendance Status")]
    public EAttendanceStatus? AttendanceStatus { get => (EAttendanceStatus)fields.AttendanceStatus[this]; set => fields.AttendanceStatus[this] = (short?)value; }

    [DisplayName("Is Active"),DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field InstituteTimeTableId;
        public Int32Field StudentId;
        public Int16Field AttendanceStatus;
        public Int16Field IsActive;
        public StringField StudentPrn;
    }
}