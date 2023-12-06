using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Analytics;

[ConnectionKey("Default"), Module("Analytics"), TableName("AssignedexamsTeachers")]
[DisplayName("Assigned Exam Teachers"), InstanceName("Assigned Exam Teachers")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class AssignedExamTeachersRow : LoggingRow<AssignedExamTeachersRow.RowFields>, IIdRow
{
    const string jExam = nameof(jExam);
    const string jPlayList = nameof(jPlayList);
    const string jTeacher = nameof(jTeacher);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey("Exams", "Id"), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [LookupEditor("Exams.Exam")]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Title"), Expression($"{jExam}.[Title]")]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ExamId;
        public Int32Field PlayListId;
        public Int32Field TeacherId;
        public BooleanField IsActive;

        public StringField ExamTitle;
        public StringField PlayListTitle;
        public StringField TeacherPrn;
    }
}