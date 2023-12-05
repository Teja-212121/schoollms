using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;
[DefaultDB, MigrationKey(202301051734)]
public class DefaultDB_20230105_1734_InitialTables : AutoReversingMigration
{
    public override void Up()
    {
        #region Syllabus
        this.CreateTableWithId32("Classes", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000).Nullable()
            .WithColumn("SortOrder").AsInt16().NotNullable()
            .WithColumn("Weightage").AsFloat().Nullable()
            .WithColumn("Thumbnail").AsString(500).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Mediums", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000)
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Subjects", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000).Nullable()
            .WithColumn("SortOrder").AsInt16().NotNullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("MediumId").AsInt32().NotNullable()
                .ForeignKey("Mediums", "Id")
            .WithColumn("Weightage").AsFloat().Nullable()
            .WithColumn("Thumbnail").AsString(500).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Topics", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000)
            .WithColumn("SortOrder").AsInt16().NotNullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("MediumId").AsInt32().NotNullable()
                .ForeignKey("Mediums", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("Weightage").AsFloat().NotNullable()
            .WithColumn("Thumbnail").AsString(500)
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Masters
        this.CreateTableWithId32("States", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("ShortName").AsString(200).NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Districts", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("StateId").AsInt32().NotNullable()
                .ForeignKey("States", "Id")
            .WithColumn("ShortName").AsString(200).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Talukas", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("StateId").AsInt32().NotNullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().NotNullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("ShortName").AsString(200).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AcademicYears", "Id", s => s
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("StartDate").AsDateTime().NotNullable()
            .WithColumn("EndDate").AsDateTime().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("BloomsTaxanomy", "Id", s => s
            .WithColumn("CoginitiveSkill").AsString().NotNullable()
            .WithColumn("SortOrder").AsInt32().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Schools
        this.CreateTableWithId32("Schools", "Id", s => s
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("eType").AsString(200).Nullable()
            .WithColumn("Address").AsString(1000).NotNullable()
            .WithColumn("City").AsString(200).NotNullable()
            .WithColumn("StateId").AsInt32().NotNullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().NotNullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("TalukaId").AsInt32().NotNullable()
                .ForeignKey("Talukas", "Id")
            .WithColumn("LocationInfo").AsString(2000).Nullable()
            .WithColumn("EstablishmentDate").AsDateTime().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        #region Users
        this.CreateTableWithId32("Teachers", "Id", s => s
            .WithColumn("PRN").AsString(500).NotNullable()
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Email").AsString(500).NotNullable()
            .WithColumn("Mobile").AsString(12).NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("Description").AsString(500).Nullable()
            .WithColumn("StateId").AsInt32().Nullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().Nullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("TalukaId").AsInt32().Nullable()
                .ForeignKey("Talukas", "Id")
            .WithColumn("DOB").AsDateTime().Nullable()
            .WithColumn("SchoolId").AsInt32().Nullable()
                .ForeignKey("Schools", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Students", "Id", s => s
            .WithColumn("PRN").AsString(500).NotNullable()
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Email").AsString(500).NotNullable()
            .WithColumn("Mobile").AsString(12).NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("Description").AsString(500).Nullable()
            .WithColumn("StateId").AsInt32().Nullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().Nullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("TalukaId").AsInt32().Nullable()
                .ForeignKey("Talukas", "Id")
            .WithColumn("DOB").AsDateTime().Nullable()
            .WithColumn("SchoolId").AsInt32().Nullable()
                .ForeignKey("Schools", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        this.CreateTableWithId32("SchoolClasses", "Id", s => s
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("Division").AsString(255).Nullable()
            .WithColumn("MediumId").AsInt32().Nullable()
                .ForeignKey("Mediums", "Id")
            .WithColumn("ClassTeacherId").AsInt32().Nullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("Title").AsString(255).Nullable()
            .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("SchoolTeachers", "Id", s => s
            .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("SchoolId").AsInt32().NotNullable()
                .ForeignKey("Schools", "Id")
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().Nullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("Description").AsString(255).Nullable()
            .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("SchoolStudents", "Id", s => s
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("SchoolId").AsInt32().NotNullable()
                .ForeignKey("Schools", "Id")
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("Division").AsString(255).Nullable()
            .WithColumn("RollNumber").AsString(50).Nullable()
            .WithColumn("Description").AsString(255).Nullable()
            .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("SchoolTimeTable", "Id", s => s
            .WithColumn("Date").AsDateTime().NotNullable()
            .WithColumn("StartTime").AsDateTime().NotNullable()
            .WithColumn("EndTime").AsDateTime().NotNullable()
            .WithColumn("PeriodIndex").AsInt32().NotNullable()
            .WithColumn("SchoolClassId").AsInt32().NotNullable()
                .ForeignKey("SchoolClasses", "Id")
            .WithColumn("TeacherId").AsInt32().Nullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("eType").AsString(50).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Content
        this.CreateTableWithId32("Contents", "Id", s => s
            .WithColumn("Title").AsString(200).NotNullable()
            .WithColumn("Description").AsString(500).Nullable()
            .WithColumn("EContentType").AsInt16().NotNullable()
            .WithColumn("FileKeyURL").AsString(int.MaxValue).NotNullable()
            .WithColumn("IV").AsString(2000).NotNullable()
            .WithColumn("FilePath").AsString(int.MaxValue).NotNullable()
            .WithColumn("FilePathFallBack1").AsString(int.MaxValue).NotNullable()
            .WithColumn("FilePathFallBack2").AsString(int.MaxValue).NotNullable()
            .WithColumn("MediaInfo").AsString(int.MaxValue).NotNullable()
            .WithColumn("ThumbNail").AsString(int.MaxValue).NotNullable()
            .WithColumn("Poster").AsString(200).NotNullable()
            .WithColumn("Length").AsInt32().NotNullable()
            .WithColumn("Size").AsInt32().NotNullable()
            .WithColumn("NumberOfPages").AsInt32().NotNullable()
            .WithColumn("LikesCount").AsInt32().NotNullable()
            .WithColumn("DisLikesCount").AsInt32().NotNullable()
            .WithColumn("HandRaiseCount").AsInt32().NotNullable()
            .WithColumn("SearchTags").AsString(500).NotNullable()
            .WithColumn("eDifficultyLevel").AsInt16().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentBloomsIndex", "Id", s => s
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("BloomsIndex").AsInt32().NotNullable()
                .ForeignKey("BloomsTaxanomy", "Id")
            .WithColumn("Weightage").AsFloat().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentTopics", "Id", s => s
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().Nullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("TopicId").AsInt32().Nullable()
                .ForeignKey("Topics", "Id")
            .WithColumn("MediumId").AsInt32().Nullable()
                .ForeignKey("Mediums", "Id")
            .WithColumn("SortOrder").AsInt16().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region QuestionBank
        this.CreateTableWithId32("QuestionCommonData", "Id", s => s
            .WithColumn("CommonDataTitle").AsString(500).NotNullable()
            .WithColumn("CommonData").AsString(Int32.MaxValue).NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId64("Questions", "Id", s => s
            .WithColumn("QuestionText").AsString(Int32.MaxValue).NotNullable()
            .WithColumn("Explaination").AsString(Int32.MaxValue).Nullable()
            .WithColumn("IsSubjective").AsBoolean().NotNullable().WithDefaultValue(false)
            .WithColumn("EQuestionType").AsInt16().NotNullable().WithDefaultValue(1)
            .WithColumn("EDifficultyLevel").AsInt16().NotNullable()
            .WithColumn("QuestionCommonDataId").AsInt32().Nullable()
                .ForeignKey("QuestionCommonData", "Id")
            .WithColumn("QuestionCommonDataSortOrder").AsFloat().Nullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("TopicId").AsInt32().Nullable()
                .ForeignKey("Topics", "Id")
            .WithColumn("BloomsIndex").AsInt32().NotNullable()
                .ForeignKey("BloomsTaxanomy", "Id")
            .WithColumn("BloomsWeightage").AsFloat().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId64("QuestionOptions", "Id", s => s
            .WithColumn("QuestionId").AsInt64().NotNullable()
                .ForeignKey("Questions", "Id")
            .WithColumn("OptionText").AsString(Int32.MaxValue).NotNullable()
            .WithColumn("IsCorrect").AsBoolean().Nullable()
            .WithColumn("SortOrder").AsFloat().NotNullable().WithDefaultValue(1)
            .WithColumn("Weightage").AsFloat().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Exams
        this.CreateTableWithId32("Exams", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("EExamType").AsInt16().NotNullable()
            .WithColumn("EExamState").AsInt16().Nullable()
            .WithColumn("QuestionPaperPath").AsString(int.MaxValue).Nullable()
            .WithColumn("ModelAnswerPaperPath").AsString(int.MaxValue).Nullable()
            .WithColumn("ExamDuration").AsInt32().Nullable().WithDefaultValue(0)
            .WithColumn("MaxMarks").AsFloat().Nullable()
            .WithColumn("NegativeMarks").AsFloat().Nullable()
            .WithColumn("EExamNavigation").AsInt16().Nullable().WithDefaultValue(0)
            .WithColumn("ESectionNavigation").AsInt16().Nullable().WithDefaultValue(0)
            .WithColumn("EQuestionNavigation").AsInt16().Nullable().WithDefaultValue(0)
            .WithColumn("EResultType").AsInt16().Nullable().WithDefaultValue(0)
            .WithColumn("EOptionDisplayType").AsInt16().Nullable().WithDefaultValue(0)
            .WithColumn("HasNegativeMarketing").AsBoolean().Nullable().WithDefaultValue(false)     
            .WithColumn("Instructions").AsString(Int32.MaxValue).Nullable()
            .WithColumn("SearchTags").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ExamSections", "Id", s => s
            .WithColumn("ExamId").AsInt32().NotNullable()
                .ForeignKey("Exams", "Id")
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Instructions").AsString(Int32.MaxValue).Nullable()
            .WithColumn("DurationInSeconds").AsInt32().Nullable()
            .WithColumn("SortOrder").AsFloat().NotNullable()
            .WithColumn("ParentId").AsInt32().Nullable()
                .ForeignKey("ExamSections", "Id")
            .WithColumn("NumberOfQuestions").AsInt32().Nullable()
            .WithColumn("NumberOfMandatoryQuestions").AsInt32().Nullable()
            .WithColumn("SearchTags").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ExamQuestions", "Id", s => s
            .WithColumn("ExamId").AsInt32().NotNullable()
                .ForeignKey("Exams", "Id")
            .WithColumn("ExamSectionId").AsInt32().Nullable()
                .ForeignKey("ExamSections", "Id")
            .WithColumn("QuestionId").AsInt64().NotNullable()
                .ForeignKey("Questions", "Id")
            .WithColumn("EDifficultyLevel").AsInt16().NotNullable()
            .WithColumn("RightAnswer").AsString(500).Nullable()
            .WithColumn("Marks").AsFloat().NotNullable()
            .WithColumn("SortOrder").AsFloat().NotNullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("TopicId").AsInt32().Nullable()
                .ForeignKey("Topics", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Assignments", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000).Nullable()
            .WithColumn("File").AsString(int.MaxValue).NotNullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AssignmentEvaluation", "Id", s => s
            .WithColumn("AssignmentId").AsInt32().NotNullable()
                .ForeignKey("Assignments", "Id")
            .WithColumn("EvalutionCriteria").AsString(1000).NotNullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("TopicId").AsInt32().NotNullable()
                .ForeignKey("Topics", "Id")
            .WithColumn("BloomsIndex").AsInt32().NotNullable()
                .ForeignKey("BloomsTaxanomy", "Id")
            .WithColumn("BloomsWeightage").AsFloat().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region LiveSessions
        this.CreateTableWithId32("LiveSessions", "Id", s => s
            .WithColumn("MeetingId").AsString(2000).NotNullable()
            .WithColumn("LiveProvider").AsInt16().NotNullable()
            .WithColumn("Password").AsString(200).NotNullable()
            .WithColumn("Secret").AsString(200).NotNullable()
            .WithColumn("LiveAdditionalInfo").AsString(2000).NotNullable()
            .WithColumn("SearchTags").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("LiveSessionLog", "Id", s => s
           .WithColumn("Date").AsDateTime().NotNullable()
           .WithColumn("StartTime").AsDateTime().NotNullable()
           .WithColumn("EndTime").AsDateTime().NotNullable()
           .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Polls", "Id", s => s
            .WithColumn("Question").AsString(500).NotNullable()
            .WithColumn("eQuestionType").AsInt16().NotNullable()
            .WithColumn("Option1").AsString(500).NotNullable()
            .WithColumn("Option2").AsString(500).NotNullable()
            .WithColumn("Option3").AsString(500).Nullable()
            .WithColumn("Option4").AsString(500).Nullable()
            .WithColumn("Option5").AsString(500).Nullable()
            .WithColumn("RightAnswer").AsString(500).Nullable()
            .WithColumn("LiveSessionLogId").AsInt32().Nullable()
                .ForeignKey("LiveSessionLog", "Id")
            .WithColumn("TotalAttempts").AsInt16().NotNullable()
            .WithColumn("AverageResponseTime").AsFloat().NotNullable()
            .WithColumn("NumberOfCorrect").AsInt16().NotNullable()
            .WithColumn("NumberOfWrong").AsInt16().NotNullable()
            .WithColumn("BloomsTaxonomyId").AsInt32().NotNullable()
                .ForeignKey("BloomsTaxanomy", "Id")
            .WithColumn("Weightage").AsFloat().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Playlist
        this.CreateTableWithId32("PlayLists", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000).Nullable()
            .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
            .WithColumn("SubjectId").AsInt32().NotNullable()
                .ForeignKey("Subjects", "Id")
            .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Modules", "Id", s => s
            .WithColumn("Title").AsString(500).NotNullable()
            .WithColumn("Description").AsString(2000).Nullable()
            .WithColumn("ParentId").AsInt32().Nullable()
                .ForeignKey("Modules", "Id")
            .WithColumn("SortOrder").AsFloat().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("PlayListContents", "Id", s => s
            .WithColumn("PlayListId").AsInt32().Nullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("ExamId").AsInt32().NotNullable()
                .ForeignKey("Exams", "Id")
            .WithColumn("LiveSessionId").AsInt32().Nullable()
                .ForeignKey("LiveSessions", "Id")
            .WithColumn("AssignmentId").AsInt32().NotNullable()
                .ForeignKey("Assignments", "Id")
            .WithColumn("ModuleId").AsInt32().Nullable()
                .ForeignKey("Modules", "Id")
            .WithColumn("SortOrder").AsFloat().NotNullable()
            .WithColumn("ePublishStatus").AsInt16().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Activation
        this.CreateTableWithId32("SerialKeys", "Id", s => s
            .WithColumn("SerialKey").AsString(100).NotNullable()
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("ValidityType").AsInt16().Nullable()
            .WithColumn("ValidityInDays").AsInt16().Nullable()
            .WithColumn("ValidDate").AsDateTime().Nullable()
            .WithColumn("Note").AsString(1000).Nullable()
            .WithColumn("eStatus").AsInt16().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("CouponCodes", "Id", s => s
            .WithColumn("Code").AsString(100).NotNullable()
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("ValidityType").AsInt16().Nullable()
            .WithColumn("CountType").AsInt16().Nullable()
            .WithColumn("Count").AsInt16().Nullable()
            .WithColumn("ValidityInDays").AsInt16().Nullable()
            .WithColumn("ValidDate").AsDateTime().Nullable()
            .WithColumn("ConsumedCount").AsInt32().Nullable()
            .WithColumn("CouponValidityDate").AsDateTime().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        
        this.CreateTableWithId32("ActivationLog", "Id", s => s
            .WithColumn("Code").AsString(100).NotNullable()
            .WithColumn("SerialKey").AsString(100).NotNullable()
            .WithColumn("TeacherId").AsInt32().Nullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("DeviceId").AsString(200).Nullable()
            .WithColumn("DeviceDetails").AsString(500).Nullable()
            .WithColumn("eStatus").AsInt16().Nullable()
            .WithColumn("Note").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Activations", "Id", s => s
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("ActivationLogId").AsInt32().NotNullable()
                .ForeignKey("ActivationLog", "Id")
            .WithColumn("DeviceId").AsString(200).Nullable()
            .WithColumn("DeviceDetails").AsString(500).Nullable()
            .WithColumn("ActivationDate").AsDateTime().Nullable()
            .WithColumn("ExpiryDate").AsDateTime().Nullable()
            .WithColumn("eStatus").AsInt16().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        #endregion

        #region Analytics
        this.CreateTableWithId32("AnalyticsLog", "Id", s => s
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("StartDatetime").AsDateTime().NotNullable()
            .WithColumn("EndDateTime").AsDateTime().NotNullable()
            .WithColumn("TimeSpent").AsInt32().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ExamAttempts", "Id", s => s
            .WithColumn("ExamId").AsInt32().NotNullable()
                .ForeignKey("Exams", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("eStatus").AsInt16().NotNullable()
            .WithColumn("TimeSpent").AsInt32().NotNullable()
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("StudentAnswerSheetUpload").AsString(int.MaxValue).Nullable()
            .WithColumn("TeacherCheckedPaperUpload").AsString(int.MaxValue).Nullable()
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ExamAttemptQuestions", "Id", s => s
            .WithColumn("ExamAttemptId").AsInt32().NotNullable()
                .ForeignKey("ExamAttempts", "Id")
            .WithColumn("ExamQuestionId").AsInt32().NotNullable()
                .ForeignKey("ExamQuestions", "Id")
            .WithColumn("OptionSelected").AsString().Nullable()
            .WithColumn("MarksObtained").AsInt32().NotNullable()
            .WithColumn("Attemptstatus").AsInt16().NotNullable()
            .WithColumn("OutOfmarks").AsInt32().NotNullable()
            .WithColumn("Result").AsString(50).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AssignedexamsTeachers", "Id", s => s
            .WithColumn("ExamId").AsInt32().NotNullable()
                .ForeignKey("Exams", "Id")
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("TeacherId").AsInt32().NotNullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().NotNullable()
            .WithColumn("UpdateUserId").AsInt32().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Attendance
        this.CreateTableWithId32("RaisehandLiveSessions", "Id", s => s
            .WithColumn("liveSessionlogId").AsInt32().NotNullable()
                .ForeignKey("LiveSessionLog", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("SessionTime").AsDateTime().Nullable()
            .WithColumn("HandRaiseStatus").AsInt16().Nullable()
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("RaisehandRecordedSessions", "Id", s => s
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("PlayListContentId").AsInt32().NotNullable()
                .ForeignKey("PlayListContents", "Id")
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("PollResponses", "Id", s => s
            .WithColumn("PollId").AsInt32().NotNullable()
                .ForeignKey("Polls", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                .ForeignKey("Students", "Id")
            .WithColumn("Response").AsString().Nullable()
            .WithColumn("ResponseTimeInSeconds").AsInt32().Nullable()
            .WithColumn("Score").AsInt32().NotNullable()
            .WithColumn("LiveSessionLogId").AsInt32().NotNullable()
                .ForeignKey("LiveSessionLog", "Id")
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AssignmentAttempts", "Id", s => s
            .WithColumn("AssignmentId").AsInt32().NotNullable()
                .ForeignKey("Assignments", "Id")
            .WithColumn("StudentId").AsInt32().Nullable()
                .ForeignKey("Students", "Id")
            .WithColumn("FileUploaded").AsString(int.MaxValue).NotNullable()
            .WithColumn("eStatus").AsString().Nullable()
            .WithColumn("TeacherId").AsInt32().Nullable()
                .ForeignKey("Teachers", "Id")
            .WithColumn("PlayListId").AsInt32().NotNullable()
                .ForeignKey("PlayLists", "Id")
            .WithColumn("ActivationId").AsInt32().NotNullable()
                .ForeignKey("Activations", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AssignmentAttemptEvaluations", "Id", s => s
            .WithColumn("AssignmentId").AsInt32().NotNullable()
                .ForeignKey("Assignments", "Id")
            .WithColumn("AssignmentAttemptId").AsInt32().NotNullable()
                .ForeignKey("AssignmentAttempts", "Id")
            .WithColumn("AssignmentEvaluationId").AsInt32().Nullable()
                .ForeignKey("AssignmentEvaluation", "Id")
            .WithColumn("MarksObtained").AsInt32().NotNullable()
            .WithColumn("EvaluationStatus").AsInt16().NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));
        #endregion

        #region Settings
        this.CreateTableWithId32("Smtp", "Id", s => s
            .WithColumn("Server").AsString(500).NotNullable()
            .WithColumn("Port").AsInt32().NotNullable()
            .WithColumn("Username").AsString(500).NotNullable()
            .WithColumn("Password").AsString(200).NotNullable()
            .WithColumn("IsSSL").AsBoolean().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Storage", "Id", s => s
            .WithColumn("AccessKeyId").AsString(1000).NotNullable()
            .WithColumn("SecretAccessKey").AsString(500).NotNullable()
            .WithColumn("Endpoint").AsString(1000).NotNullable()
            .WithColumn("Region").AsString(100).NotNullable()
            .WithColumn("BucketName").AsString(100).NotNullable()
            .WithColumn("S3Types").AsInt16().NotNullable()
            .WithColumn("IsDefault").AsBoolean().Nullable()
            .WithColumn("UrlPreview").AsString(int.MaxValue).Nullable()
            .WithColumn("UploadPath").AsString(int.MaxValue).NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("SMS", "Id", s => s
            .WithColumn("APIKey").AsString(500).NotNullable()
            .WithColumn("Sender").AsString(500).Nullable()
            .WithColumn("EntityId").AsString(500).NotNullable()
            .WithColumn("TemplateId").AsString(500).NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        Create.Table("Notifications").InSchema("dbo")
            .WithColumn("Id").AsInt32().Identity().NotNullable().PrimaryKey()
            .WithColumn("NotificationGuid").AsGuid().Nullable()
            .WithColumn("Message").AsString(Int32.MaxValue).NotNullable()
            .WithColumn("Title").AsString(Int32.MaxValue).NotNullable()
            .WithColumn("CreatedOnUtc").AsDateTime().NotNullable()
            .WithColumn("SentTries").AsInt32().Nullable()
            .WithColumn("SentOnUtc").AsDateTime().Nullable()
            .WithColumn("HasError").AsBoolean().Nullable()
            .WithColumn("Result").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1);
        #endregion
    }
}