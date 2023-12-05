using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Schools;

[ConnectionKey("Default"), Module("Schools"), TableName("SchoolTimeTable")]
[DisplayName("School Time Table"), InstanceName("School Time Table"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class SchoolTimeTableRow : Row<SchoolTimeTableRow.RowFields>, IIdRow, INameRow
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
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Type"), Column("eType"), Size(50), QuickSearch, NameProperty]
    public string EType { get => fields.EType[this]; set => fields.EType[this] = value; }

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

    [DisplayName("School Class Division"), Origin(jSchoolClass, nameof(SchoolClassRow.Division))]
    public string SchoolClassDivision { get => fields.SchoolClassDivision[this]; set => fields.SchoolClassDivision[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }
}