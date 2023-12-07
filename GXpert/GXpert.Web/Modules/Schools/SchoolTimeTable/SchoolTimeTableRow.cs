using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Schools;

[ConnectionKey("Default"), Module("Schools"), TableName("SchoolTimeTable")]
[DisplayName("School Time Table"), InstanceName("School Time Table")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SchoolTimeTableRow : LoggingRow<SchoolTimeTableRow.RowFields>, IIdRow, INameRow
{
    const string jSchoolClass = nameof(jSchoolClass);
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

    [DisplayName("School Class"), NotNull, ForeignKey(typeof(SchoolClassRow)), LeftJoin(jSchoolClass)]
    [TextualField(nameof(SchoolClassDivision)), ServiceLookupEditor(typeof(SchoolClassRow))]
    public int? SchoolClassId { get => fields.SchoolClassId[this]; set => fields.SchoolClassId[this] = value; }

    [DisplayName("Teacher"), ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType"), Size(50), QuickSearch, NameProperty]
    public ESchoolTimeTableType? EType { get => (ESchoolTimeTableType?)fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("School Class Division"), Origin(jSchoolClass, nameof(SchoolClassRow.Division))]
    public string SchoolClassDivision { get => fields.SchoolClassDivision[this]; set => fields.SchoolClassDivision[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public DateTimeField Date;
        public DateTimeField StartTime;
        public DateTimeField EndTime;
        public Int32Field PeriodIndex;
        public Int32Field SchoolClassId;
        public Int32Field TeacherId;
        public Int16Field EType;
        public BooleanField IsActive;

        public StringField SchoolClassDivision;
        public StringField TeacherPrn;
    }
}