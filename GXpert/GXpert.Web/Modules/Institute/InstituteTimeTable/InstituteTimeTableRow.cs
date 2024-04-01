using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteTimeTable")]
[DisplayName("Institute Time Table"), InstanceName("Institute Time Table")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class InstituteTimeTableRow : LoggingRow<InstituteTimeTableRow.RowFields>, IIdRow
{
    const string jinstitutedivision = nameof(jinstitutedivision);
    const string jTeacher = nameof(jTeacher);
    const string jInstitute = nameof(jInstitute);
    const string jdepartment = nameof(jdepartment);
    const string jbranch = nameof(jbranch);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Date"), NotNull]
    public DateTime? Date { get => fields.Date[this]; set => fields.Date[this] = value; }

    [DisplayName("Start Time"), NotNull]
    public DateTime? StartTime { get => fields.StartTime[this]; set => fields.StartTime[this] = value; }

    [DisplayName("End Time"), NotNull]
    public DateTime? EndTime { get => fields.EndTime[this]; set => fields.EndTime[this] = value; }

    [DisplayName("Period Index"), NotNull]
    public int? PeriodIndex { get => fields.PeriodIndex[this]; set => fields.PeriodIndex[this] = value; }

    [DisplayName("Teacher"), ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow))]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public EInstituteTimeTableType? EType { get =>(EInstituteTimeTableType) fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Teacher Prn"), Origin(jTeacher, nameof(Users.TeacherRow.Prn))]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("ClassRoomNo"), Size(50)]
    public int? ClassRoomNo { get => fields.ClassRoomNo[this]; set => fields.ClassRoomNo[this] = value; }

    [DisplayName("Teacher Attendance Status")]
    public ETeacherAttendanceStatus? TeacherAttendanceStatus { get => (ETeacherAttendanceStatus)fields.TeacherAttendanceStatus[this]; set => fields.TeacherAttendanceStatus[this] = (short?)value; }

    [DisplayName("Institute"), ForeignKey(typeof(InstituteRow)), LeftJoin(jInstitute)]
    [LookupEditor("Institute.Institute")]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    [DisplayName("InstituteName"), Expression($"{jInstitute}.[Name]")]
    public string InstituteName{ get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }
    [DisplayName("Department"), ForeignKey(typeof(DepartmentRow)), LeftJoin(jdepartment)]
    [LookupEditor("Institute.Department")]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("DepartmentName"), Expression($"{jdepartment}.[Title]")]
    public string DepartmentName { get => fields.DepartmentName[this]; set => fields.DepartmentName[this] = value; }
    [DisplayName("Branch"), ForeignKey(typeof(BranchRow)), LeftJoin(jbranch)]
    [LookupEditor("Institute.Branch")]
    public int? BranchId { get => fields.BranchId[this]; set => fields.BranchId[this] = value; }

    [DisplayName("BranchName"), Expression($"{jbranch}.[Title]")]
    public string BranchName { get => fields.BranchName[this]; set => fields.BranchName[this] = value; }
    [DisplayName("InstituteDivision"), ForeignKey(typeof(InstituteDivisionRow)), LeftJoin(jinstitutedivision)]
    [LookupEditor("Institute.InstituteDivision")]
    public int? InstituteDivisionId { get => fields.InstituteDivisionId[this]; set => fields.InstituteDivisionId[this] = value; }

    [DisplayName("InstitudeDivisionName"), Expression($"{jinstitutedivision}.[Division]")]
    public string InstitudeDivisionName { get => fields.InstitudeDivisionName[this]; set => fields.InstitudeDivisionName[this] = value; }
    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public DateTimeField Date;
        public DateTimeField StartTime;
        public DateTimeField EndTime;
        public Int32Field PeriodIndex;
        public Int32Field InstituteDivisionId;
        public Int32Field TeacherId;
        public Int32Field InstituteId;
        public StringField InstituteName;
        public Int32Field DepartmentId;
        public StringField DepartmentName;
        public Int32Field BranchId;
        public StringField BranchName;
        public Int16Field EType;
        public BooleanField IsActive;
        public Int32Field ClassRoomNo;
        public StringField InstitudeDivisionName;
        public StringField TeacherPrn;
        public Int16Field TeacherAttendanceStatus;
    }
}