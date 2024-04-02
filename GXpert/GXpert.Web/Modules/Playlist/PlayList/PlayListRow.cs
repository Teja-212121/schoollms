using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Playlist;

[ConnectionKey("Default"), Module("Playlist"), TableName("PlayLists")]
[DisplayName("Play List"), InstanceName("Play List")]
[ReadPermission(PermissionKeys.PlaylistManagement.View)]
[ModifyPermission(PermissionKeys.PlaylistManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Playlist.PlayList",Permission ="*")]
public sealed class PlayListRow : LoggingRow<PlayListRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTeacher = nameof(jTeacher);
    const string jSemester = nameof(jSemester);
    const string jCourse = nameof(jCourse);
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Teacher"), ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }
    [DisplayName("Course"), ForeignKey("Course", "Id"), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Semester"), ForeignKey("Semester", "Id"), LeftJoin(jSemester), TextualField(nameof(SemesterName))]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }
    [DisplayName("SemesterName"), Expression($"{jSemester}.[Title]")]
    public string SemesterName { get => fields.SemesterName[this]; set => fields.SemesterName[this] = value; }
    [DisplayName("Course Title"), Expression($"{jCourse}.[Title]")]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }
    [DisplayName("Play List File Path")]
    public string PlayListFilePath { get => fields.PlayListFilePath[this]; set => fields.PlayListFilePath[this] = value; }
    
    [DisplayName("Play List Version")]
    public int? PlayListVersion { get => fields.PlayListVersion[this]; set => fields.PlayListVersion[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public Int32Field TeacherId; 
        public StringField PlayListFilePath;
        public Int32Field PlayListVersion;
        public BooleanField IsActive;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField TeacherPrn;
        public Int32Field CourseId;
        public Int32Field SemesterId;
        public StringField SemesterName;
    }
}