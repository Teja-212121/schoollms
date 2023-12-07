using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Analytics;

[ConnectionKey("Default"), Module("Analytics"), TableName("ExamAttempts")]
[DisplayName("Exam Attempt"), InstanceName("Exam Attempt")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ExamAttemptRow : LoggingRow<ExamAttemptRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);
    const string jStudent = nameof(jStudent);
    const string jTeacher = nameof(jTeacher);
    const string jPlayList = nameof(jPlayList);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey("Exams", "Id"), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [LookupEditor("Exams.Exam")]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("E Status"), Column("eStatus"), NotNull]
    public EExamAttemptStatus? EStatus { get => (EExamAttemptStatus?)fields.EStatus[this]; set => fields.EStatus[this] = (short?)value; }

    [DisplayName("Time Spent"), NotNull]
    public int? TimeSpent { get => fields.TimeSpent[this]; set => fields.TimeSpent[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Student Answer Sheet Upload"), QuickSearch, NameProperty]
    public string StudentAnswerSheetUpload { get => fields.StudentAnswerSheetUpload[this]; set => fields.StudentAnswerSheetUpload[this] = value; }

    [DisplayName("Teacher Checked Paper Upload")]
    public string TeacherCheckedPaperUpload { get => fields.TeacherCheckedPaperUpload[this]; set => fields.TeacherCheckedPaperUpload[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Title"), Expression($"{jExam}.[Title]")]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ExamId;
        public Int32Field StudentId;
        public Int32Field TeacherId;
        public Int16Field EStatus;
        public Int32Field TimeSpent;
        public Int32Field PlayListId;
        public StringField StudentAnswerSheetUpload;
        public StringField TeacherCheckedPaperUpload;
        public Int32Field ActivationId;
        public BooleanField IsActive;

        public StringField ExamTitle;
        public StringField StudentPrn;
        public StringField TeacherPrn;
        public StringField PlayListTitle;
        public StringField ActivationDeviceId;
    }
}