using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("QuestionCourse")]
[DisplayName("Question Course"), InstanceName("Question Course")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class QuestionCourseRow : Row<QuestionCourseRow.RowFields>, IIdRow
{
    const string jQuestion = nameof(jQuestion);
    const string jCourse = nameof(jCourse);
    const string jClass = nameof(jClass);
    const string jSemester = nameof(jSemester);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), ForeignKey(typeof(QuestionRow)), LeftJoin(jQuestion), TextualField(nameof(QuestionText))]
    [LookupEditor(typeof(QuestionRow), Async = true)]
    public long? QuestionId { get => fields.QuestionId[this]; set => fields.QuestionId[this] = value; }

    [DisplayName("Course"), NotNull, ForeignKey(typeof(Syllabus.CourseRow)), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    [LookupEditor(typeof(Syllabus.CourseRow), Async = true)]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow), Async = true)]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Semester"), NotNull, ForeignKey(typeof(Syllabus.SemesterRow)), LeftJoin(jSemester), TextualField(nameof(SemesterTitle))]
    [LookupEditor(typeof(Syllabus.SemesterRow), Async = true)]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("User"), ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Question Question Text"), Origin(jQuestion, nameof(QuestionRow.QuestionText))]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }

    [DisplayName("Course Title"), Origin(jCourse, nameof(Syllabus.CourseRow.Title))]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Semester Title"), Origin(jSemester, nameof(Syllabus.SemesterRow.Title))]
    public string SemesterTitle { get => fields.SemesterTitle[this]; set => fields.SemesterTitle[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int64Field QuestionId;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public Int32Field SemesterId;
        public Int32Field UserId;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public Int16Field IsActive;

        public StringField QuestionText;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public StringField SemesterTitle;
        public StringField Username;
    }
}