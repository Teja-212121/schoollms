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
    const string jInstituteClass = nameof(jInstituteClass);
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

    [DisplayName("Institute Class"), NotNull, ForeignKey(typeof(InstituteClassRow)), LeftJoin(jInstituteClass)]
    [ServiceLookupEditor(typeof(InstituteClassRow), Service = "Institute/InstituteClass/List")]
    public int? InstituteClassesId { get => fields.InstituteClassesId[this]; set => fields.InstituteClassesId[this] = value; }

    [DisplayName("Teacher"), ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow), Async = true)]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public EInstituteTimeTableType? EType { get =>(EInstituteTimeTableType) fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("School Class Division"), Expression($"{jInstituteClass}.[Division]")]
    public string InstituteClassDivision { get => fields.InstituteClassDivision[this]; set => fields.InstituteClassDivision[this] = value; }

    [DisplayName("Teacher Prn"), Origin(jTeacher, nameof(Users.TeacherRow.Prn))]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public DateTimeField Date;
        public DateTimeField StartTime;
        public DateTimeField EndTime;
        public Int32Field PeriodIndex;
        public Int32Field InstituteClassesId;
        public Int32Field TeacherId;
        public Int16Field EType;
        public BooleanField IsActive;

        public StringField InstituteClassDivision;
        public StringField TeacherPrn;
    }
}