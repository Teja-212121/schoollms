using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("ExamSections")]
[DisplayName("Exam Section"), InstanceName("Exam Section")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Exams.Exam Section")]
public sealed class ExamSectionRow : LoggingRow<ExamSectionRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);
    const string jParent = nameof(jParent);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);
    const string jCourse = nameof(jCourse);
    const string jSemester = nameof(jSemester);


    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey(typeof(ExamRow)), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [ServiceLookupEditor(typeof(ExamRow))]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Instructions")]
    public string Instructions { get => fields.Instructions[this]; set => fields.Instructions[this] = value; }

    [DisplayName("Duration In Seconds")]
    public int? DurationInSeconds { get => fields.DurationInSeconds[this]; set => fields.DurationInSeconds[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Parent"), ForeignKey(typeof(ExamSectionRow)), LeftJoin(jParent), TextualField(nameof(ParentTitle))]
    [ServiceLookupEditor(typeof(ExamSectionRow))]
    public int? ParentId { get => fields.ParentId[this]; set => fields.ParentId[this] = value; }

    [DisplayName("Number Of Questions")]
    public int? NumberOfQuestions { get => fields.NumberOfQuestions[this]; set => fields.NumberOfQuestions[this] = value; }

    [DisplayName("Number Of Mandatory Questions")]
    public int? NumberOfMandatoryQuestions { get => fields.NumberOfMandatoryQuestions[this]; set => fields.NumberOfMandatoryQuestions[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Title"), Origin(jExam, nameof(ExamRow.Title))]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Parent Title"), Origin(jParent, nameof(ExamSectionRow.Title))]
    public string ParentTitle { get => fields.ParentTitle[this]; set => fields.ParentTitle[this] = value; }

    [DisplayName("Class"), ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    [LookupEditor("Syllabus.Topic")]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }

    [DisplayName("Course"), ForeignKey("Course", "Id"), LeftJoin(jCourse)]
    [LookupEditor("Syllabus.Course")]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Course Title"), Expression($"{jCourse}.[Title]")]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Semester"), ForeignKey("Semester", "Id"), LeftJoin(jSemester)]
    [LookupEditor("Syllabus.Semester")]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("Semester Title"), Expression($"{jCourse}.[Title]")]
    public string SemesterTitle { get => fields.SemesterTitle[this]; set => fields.SemesterTitle[this] = value; }
    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ExamId;
        public StringField Title;
        public StringField Instructions;
        public Int32Field DurationInSeconds;
        public SingleField SortOrder;
        public Int32Field ParentId;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public Int32Field SemesterId;
        public Int32Field SubjectId;
        public Int32Field TopicId;
        public Int32Field NumberOfQuestions;
        public Int32Field NumberOfMandatoryQuestions;
        public StringField SearchTags;
        public BooleanField IsActive;

        public StringField ExamTitle;
        public StringField ParentTitle;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public StringField SemesterTitle;
        public StringField SubjectTitle;
        public StringField TopicTitle;
    }
}