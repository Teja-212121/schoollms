using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240322_122207)]
    public class DefaultDB_20240322_122207_NewTables : Migration
    {
        public override void Up()
        {

        Rename.Table("Schools").To("Institutes");
        Rename.Table("SchoolClasses").To("InstituteClasses");
        Rename.Table("SchoolTeachers").To("InstituteTeachers");
        Rename.Table("SchoolStudents").To("InstituteStudents");

       
        this.CreateTableWithId32("Course", "Id", s => s
        .WithColumn("Title").AsString(500).NotNullable()
        .WithColumn("Description").AsString(2000).Nullable()
        .WithColumn("SortOrder").AsInt16().Nullable()
        .WithColumn("Thumbnail").AsString(500).Nullable()
        .WithColumn("InsertDate").AsDateTime().NotNullable()
        .WithColumn("InsertUserId").AsInt32().NotNullable()
        .WithColumn("UpdateDate").AsDateTime().Nullable()
        .WithColumn("UpdateUserId").AsInt32().Nullable()
        .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        Alter.Table("Classes")
        .AddColumn("CourseId").AsInt32().NotNullable()
                .ForeignKey("Course", "Id");


      this.CreateTableWithId32("Semester", "Id", s => s
     .WithColumn("Title").AsString(500).NotNullable()
     .WithColumn("CourseId").AsInt32().NotNullable()
                .ForeignKey("Course", "Id")
     .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
     .WithColumn("InsertDate").AsDateTime().NotNullable()
     .WithColumn("InsertUserId").AsInt32().NotNullable()
     .WithColumn("UpdateDate").AsDateTime().Nullable()
     .WithColumn("UpdateUserId").AsInt32().Nullable()
     .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        Alter.Table("Subjects")
       .AddColumn("CourseId").AsInt32().NotNullable()
               .ForeignKey("Course", "Id")
       .AddColumn("SemesterId").AsInt32().NotNullable()
               .ForeignKey("Semester", "Id")
               ;
        Alter.Table("Topics")
            .AddColumn("CourseId").AsInt32().NotNullable()
              .ForeignKey("Course", "Id")
            .AddColumn("SemesterId").AsInt32().NotNullable()
              .ForeignKey("Semester", "Id");


        this.CreateTableWithId32("Principal", "Id", s => s
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Email").AsString(500).NotNullable()
            .WithColumn("Mobile").AsString(12).NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("StateId").AsInt32().Nullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().Nullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("TalukaId").AsInt32().Nullable()
                .ForeignKey("Talukas", "Id")
            .WithColumn("DOB").AsDateTime().Nullable()
            .WithColumn("InstituteId").AsInt32().Nullable()
                .ForeignKey("Institutes", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        this.CreateTableWithId32("Hod", "Id", s => s
            .WithColumn("Name").AsString(500).NotNullable()
            .WithColumn("Email").AsString(500).NotNullable()
            .WithColumn("Mobile").AsString(12).NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("StateId").AsInt32().Nullable()
                .ForeignKey("States", "Id")
            .WithColumn("DistrictId").AsInt32().Nullable()
                .ForeignKey("Districts", "Id")
            .WithColumn("TalukaId").AsInt32().Nullable()
                .ForeignKey("Talukas", "Id")
            .WithColumn("DOB").AsDateTime().Nullable()
            .WithColumn("InstituteId").AsInt32().Nullable()
                .ForeignKey("Institutes", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Departments", "Id", s => s
          .WithColumn("Title").AsString(500).NotNullable()
          .WithColumn("InstituteId").AsInt32().NotNullable()
                .ForeignKey("Institutes", "Id")
          .WithColumn("HodId").AsInt32().NotNullable()
              .ForeignKey("Hod", "Id")
          .WithColumn("Description").AsString(2000).Nullable()
          .WithColumn("InsertDate").AsDateTime().NotNullable()
          .WithColumn("InsertUserId").AsInt32().NotNullable()
          .WithColumn("UpdateDate").AsDateTime().Nullable()
          .WithColumn("UpdateUserId").AsInt32().Nullable()
          .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Branch", "Id", s => s
         .WithColumn("Title").AsString(500).NotNullable()
         .WithColumn("InstituteId").AsInt32().NotNullable()
                .ForeignKey("Institutes", "Id")
         .WithColumn("DepartmentId").AsInt32().NotNullable()
                .ForeignKey("Departments", "Id")
         .WithColumn("Description").AsString(2000).Nullable()
          .WithColumn("InsertDate").AsDateTime().NotNullable()
         .WithColumn("InsertUserId").AsInt32().NotNullable()
         .WithColumn("UpdateDate").AsDateTime().Nullable()
         .WithColumn("UpdateUserId").AsInt32().Nullable()
         .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        this.CreateTableWithId32("SkillCategory", "Id", s => s
        .WithColumn("Name").AsString(500).NotNullable()
        .WithColumn("Description").AsString(500).Nullable()
         .WithColumn("InsertDate").AsDateTime().NotNullable()
        .WithColumn("InsertUserId").AsInt32().NotNullable()
        .WithColumn("UpdateDate").AsDateTime().Nullable()
        .WithColumn("UpdateUserId").AsInt32().Nullable()
        .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("Skills", "Id", s => s
      .WithColumn("Name").AsString(500).NotNullable()
      .WithColumn("Description").AsString(500).Nullable()
      .WithColumn("SkillCategoryId").AsInt32().NotNullable()
                .ForeignKey("SkillCategory", "Id")
       .WithColumn("InsertDate").AsDateTime().NotNullable()
      .WithColumn("InsertUserId").AsInt32().NotNullable()
      .WithColumn("UpdateDate").AsDateTime().Nullable()
      .WithColumn("UpdateUserId").AsInt32().Nullable()
      .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        Alter.Table("Activations")
            .AddColumn("StudentId").AsInt32().NotNullable()
            .ForeignKey("Students", "Id")
            .AlterColumn("TeacherId").AsInt32().Nullable();

        Alter.Table("PlayLists")
          .AddColumn("CourseId").AsInt32().Nullable()
              .ForeignKey("Course", "Id")
          .AddColumn("SemesterId").AsInt32().Nullable()
              .ForeignKey("Semester", "Id")
          .AlterColumn("TeacherId").AsInt32().Nullable(); ;

        Alter.Table("Questions")
        .AddColumn("CourseId").AsInt32().Nullable()
            .ForeignKey("Course", "Id")
        .AddColumn("SemesterId").AsInt32().Nullable()
            .ForeignKey("Semester", "Id")
        .AddColumn("SkillCategoryId").AsInt32().Nullable()
            .ForeignKey("SkillCategory", "Id")
        .AddColumn("SkillsId").AsInt32().Nullable()
            .ForeignKey("Skills", "Id");

        Alter.Table("InstituteClasses")
         .AddColumn("InstituteId").AsInt32().Nullable()
                .ForeignKey("Institutes", "Id")
        .AddColumn("DepartmentId").AsInt32().Nullable()
                .ForeignKey("Departments", "Id")
        .AddColumn("CourseId").AsInt32().Nullable()
            .ForeignKey("Course", "Id")
       ;


        Alter.Table("Institutes")
         .AddColumn("PrincipalId").AsInt32().Nullable()
                .ForeignKey("Principal", "Id");

        Alter.Table("Students")
      .AddColumn("PrincipalId").AsInt32().Nullable()
             .ForeignKey("Principal", "Id");


    }
    public override void Down()
        {

        }
    }
