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
    const string jInstituteDivision = nameof(jInstituteDivision);
    const string jTeacher = nameof(jTeacher);

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

    [DisplayName("Division"), NotNull, ForeignKey(typeof(InstituteDivisionRow)), LeftJoin(jInstituteDivision)]
    [LookupEditor("Institute.InstituteDivision")]
    public int? InstituteDivisionId { get => fields.InstituteDivisionId[this]; set => fields.InstituteDivisionId[this] = value; }

    [DisplayName("Teacher"), ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow))]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public EInstituteTimeTableType? EType { get =>(EInstituteTimeTableType) fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("InstituteClassDivision"), Expression($"{jInstituteDivision}.[Division]")]
    public string InstituteClassDivision { get => fields.InstituteClassDivision[this]; set => fields.InstituteClassDivision[this] = value; }

    [DisplayName("Teacher Prn"), Origin(jTeacher, nameof(Users.TeacherRow.Prn))]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("ClassRoomNo"), Size(50)]
    public int? ClassRoomNo { get => fields.ClassRoomNo[this]; set => fields.ClassRoomNo[this] = value; }

    [DisplayName("Teacher Attendance Status")]
    public ETeacherAttendanceStatus? TeacherAttendanceStatus { get => (ETeacherAttendanceStatus)fields.TeacherAttendanceStatus[this]; set => fields.TeacherAttendanceStatus[this] = (short?)value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public DateTimeField Date;
        public DateTimeField StartTime;
        public DateTimeField EndTime;
        public Int32Field PeriodIndex;
        public Int32Field InstituteDivisionId;
        public Int32Field TeacherId;
        public Int16Field EType;
        public BooleanField IsActive;
        public Int32Field ClassRoomNo;
        public StringField InstituteClassDivision;
        public StringField TeacherPrn;
        public Int16Field TeacherAttendanceStatus;
    }
}