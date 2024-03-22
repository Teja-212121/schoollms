using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteTimeTable")]
[DisplayName("Institute Time Table"), InstanceName("Institute Time Table")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class InstituteTimeTableRow : Row<InstituteTimeTableRow.RowFields>, IIdRow
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

    [DisplayName("School Class"), NotNull, ForeignKey(typeof(InstituteClassRow)), LeftJoin(jSchoolClass)]
    [TextualField(nameof(SchoolClassDivision))]
    [ServiceLookupEditor(typeof(InstituteClassRow), Service = "Institute/InstituteClass/List")]
    public int? SchoolClassId { get => fields.SchoolClassId[this]; set => fields.SchoolClassId[this] = value; }

    [DisplayName("Teacher"), ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow), Async = true)]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public short? EType { get => fields.EType[this]; set => fields.EType[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("School Class Division"), Origin(jSchoolClass, nameof(InstituteClassRow.Division))]
    public string SchoolClassDivision { get => fields.SchoolClassDivision[this]; set => fields.SchoolClassDivision[this] = value; }

    [DisplayName("Teacher Prn"), Origin(jTeacher, nameof(Users.TeacherRow.Prn))]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public DateTimeField Date;
        public DateTimeField StartTime;
        public DateTimeField EndTime;
        public Int32Field PeriodIndex;
        public Int32Field SchoolClassId;
        public Int32Field TeacherId;
        public Int16Field EType;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField SchoolClassDivision;
        public StringField TeacherPrn;
    }
}