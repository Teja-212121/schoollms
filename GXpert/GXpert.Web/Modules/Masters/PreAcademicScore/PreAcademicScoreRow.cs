using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("PreAcademicsScore")]
[DisplayName("Pre Academic Score"), InstanceName("Pre Academic Score")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class PreAcademicScoreRow : LoggingRow<PreAcademicScoreRow.RowFields>, IIdRow, INameRow
{
    const string jPreAcadamics = nameof(jPreAcadamics);
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Pre Acadamics"), NotNull, ForeignKey("PreAcademics", "Id"), LeftJoin(jPreAcadamics)]
    [TextualField(nameof(PreAcadamicsExamName))]
    [LookupEditor("Masters.PreAcademic")]
    public int? PreAcadamicsId { get => fields.PreAcadamicsId[this]; set => fields.PreAcadamicsId[this] = value; }

    [DisplayName("Passed Out Date")]
    public DateTime? PassedOutDate { get => fields.PassedOutDate[this]; set => fields.PassedOutDate[this] = value; }

    [DisplayName("Marks Obtained")]
    public float? MarksObtained { get => fields.MarksObtained[this]; set => fields.MarksObtained[this] = value; }

    [DisplayName("Out Of Marks")]
    public float? OutOfMarks { get => fields.OutOfMarks[this]; set => fields.OutOfMarks[this] = value; }

    [DisplayName("Student"), ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
   // [LookupEditor(typeof(Users.StudentRow), Async = true)]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Remarks"), Size(500), QuickSearch, NameProperty]
    public string Remarks { get => fields.Remarks[this]; set => fields.Remarks[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Pre Acadamics Exam Name"), Expression($"{jPreAcadamics}.[ExamName]")]
    public string PreAcadamicsExamName { get => fields.PreAcadamicsExamName[this]; set => fields.PreAcadamicsExamName[this] = value; }

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field PreAcadamicsId;
        public DateTimeField PassedOutDate;
        public SingleField MarksObtained;
        public SingleField OutOfMarks;
        public Int32Field StudentId;
        public StringField Remarks;
       
        public BooleanField IsActive;

        public StringField PreAcadamicsExamName;
        public StringField StudentPrn;
    }
}