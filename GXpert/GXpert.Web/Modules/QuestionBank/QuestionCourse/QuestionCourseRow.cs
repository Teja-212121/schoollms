using GXpert.Syllabus;
using Microsoft.AspNetCore.Components;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("QuestionCourse")]
[DisplayName("Question Course"), InstanceName("Question Course")]
[ReadPermission(PermissionKeys.QuestionBankManagement.View)]
[ModifyPermission(PermissionKeys.QuestionBankManagement.Modify)]
[LookupScript("QuestionBank.Question Course")]
public sealed class QuestionCourseRow : LoggingRow<QuestionCourseRow.RowFields>, IIdRow
{
    const string jQuestion = nameof(jQuestion);
    const string jCourse = nameof(jCourse);
    const string jClass = nameof(jClass);
    const string jSemester = nameof(jSemester);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), ForeignKey(typeof(QuestionRow)), LeftJoin(jQuestion), TextualField(nameof(QuestionText))]
    [LookupEditor("QuestionBank.Question")]
    public long? QuestionId { get => fields.QuestionId[this]; set => fields.QuestionId[this] = value; }

    [DisplayName("Course"), NotNull, ForeignKey(typeof(Syllabus.CourseRow)), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    [LookupEditor(typeof(Syllabus.CourseRow))]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow),CascadeFrom ="CourseId",CascadeField = "CourseId")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

   

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Question Question Text"), Expression($"{jQuestion}.[QuestionText]")]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }

    [DisplayName("Course Title"), Origin(jCourse, nameof(Syllabus.CourseRow.Title))]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Semester"), NotNull, ForeignKey("Semester", "Id"), LeftJoin(jSemester)]
    [ServiceLookupEditor(typeof(SemesterRow), CascadeFrom = "ClassId", CascadeField = "ClassId"), LookupInclude]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("SemesterTitle"), Expression($"{jSemester}.[Title]")]
    public string SemesterTitle { get => fields.SemesterTitle[this]; set => fields.SemesterTitle[this] = value; }
    [DisplayName("Subject"), ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject", CascadeFrom = "SemesterId", CascadeField = "SemesterId")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    [LookupEditor("Syllabus.Topic", CascadeFrom = "SubjectId", CascadeField = "SubjectId"),LookupInclude]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }
    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }


    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int64Field QuestionId;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public Int32Field TopicId;
        public Int32Field SubjectId;
        public Int32Field SemesterId;
        public Int16Field IsActive;
        public StringField QuestionText;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public StringField SemesterTitle;
        public StringField TopicTitle;
        public StringField SubjectTitle;

    }
}