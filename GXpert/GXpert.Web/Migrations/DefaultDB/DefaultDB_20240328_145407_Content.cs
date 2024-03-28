using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240328_145407)]
public class DefaultDB_20240328_145407_Content : Migration
{
    public override void Up()
    {
       

        Alter.Table("Contents")
           .AddColumn("AllowDownload").AsBoolean().NotNullable()
               .WithDefaultValue(false)
           .AddColumn("DurationInSeconds").AsInt32().NotNullable()
               .WithDefaultValue(0)
           .AddColumn("EnableComments").AsBoolean().NotNullable()
               .WithDefaultValue(false)
           .AddColumn("EncodingStatus").AsString(100).Nullable()
           .AddColumn("FriendlyToken").AsString(100).Nullable()
           .AddColumn("EContentState").AsInt16().NotNullable()
               .WithDefaultValue(0)
           .AddColumn("Views").AsInt32().NotNullable()
               .WithDefaultValue(0)
           .AddColumn("IsFeatured").AsBoolean().NotNullable().WithDefaultValue(false)
           .AddColumn("IsReviewed").AsBoolean().NotNullable().WithDefaultValue(true)
           .AddColumn("IsListed").AsBoolean().NotNullable().WithDefaultValue(false)
           .AddColumn("ThumbnailTime").AsDouble().Nullable()
           .AddColumn("Md5sum").AsString(100).Nullable()
            .AddColumn("IsUserFeatured").AsBoolean().NotNullable()
               .WithDefaultValue(false)
           .AddColumn("SizeInBytes").AsInt64().NotNullable()
               .WithDefaultValue(0)
           .AddColumn("MediaVersion").AsInt16().NotNullable().WithDefaultValue(1)
           .AddColumn("MediaFile").AsString(1000).NotNullable()
            .AddColumn("HlsFile").AsString(1000).Nullable()
           .AddColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
          .AddColumn("DownloadFilePrimaryUrl").AsString(500).NotNullable()
          .AddColumn("DownloadFileFallback1Url").AsString(500).Nullable()
          .AddColumn("DownloadFileFallback2Url").AsString(500).Nullable()
          .AddColumn("M3u8FilePrimaryUrl").AsString(500).Nullable()
          .AddColumn("M3u8FileFallback1Url").AsString(500).Nullable()
          .AddColumn("M3u8FileFallback2Url").AsString(500).Nullable();


        this.CreateTableWithId32("ContentCategories", "Id", s => s
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("IsGlobal").AsBoolean().NotNullable()
                .WithDefaultValue(false)
            .WithColumn("MediaCount").AsInt32().NotNullable()
                .WithDefaultValue(0)
            .WithColumn("Thumbnail").AsString(500).Nullable()
            .WithColumn("ListingThumbnail").AsString(500).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentLanguages", "Id", s => s
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Description").AsString(1000).NotNullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentLicenses", "Id", s => s
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentAudio", "Id", s => s
            .WithColumn("MediaFile").AsString(1000).NotNullable()
            .WithColumn("HlsFile").AsString(1000).Nullable()
            .WithColumn("FileKeyUrl").AsString(1000).Nullable()
            .WithColumn("IV").AsString(500).Nullable()
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("LanguageId").AsInt32().NotNullable()
                .ForeignKey("ContentLanguages", "Id")
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

       

        this.CreateTableWithId32("ContentSubtitles", "Id", s => s
            .WithColumn("SubtitleFile").AsString(1000).NotNullable()
            .WithColumn("ContentId").AsInt32().NotNullable()
                .ForeignKey("Contents", "Id")
            .WithColumn("LanguageId").AsInt32().NotNullable()
                .ForeignKey("ContentLanguages", "Id")
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentComments", "Id", s => s
          .WithColumn("CommentText").AsString(100).NotNullable()
          .WithColumn("CommentLeft").AsInt32().NotNullable()
          .WithColumn("CommentRight").AsInt32().NotNullable()
          .WithColumn("TreeId").AsInt32().NotNullable()
          .WithColumn("CommentLevel").AsInt32().NotNullable()
          .WithColumn("ParentId").AsInt32().Nullable()
              .ForeignKey("ContentComments", "Id")
          .WithColumn("ContentId").AsInt32().NotNullable()
              .ForeignKey("Contents", "Id")
          .WithColumn("UserId").AsInt32().NotNullable()
              .ForeignKey("Users", "UserId")
          .WithColumn("InsertDate").AsDateTime().NotNullable()
          .WithColumn("InsertUserId").AsInt32().NotNullable()
          .WithColumn("UpdateDate").AsDateTime().Nullable()
          .WithColumn("UpdateUserId").AsInt32().Nullable()
          .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentRatings", "Id", s => s
           .WithColumn("Name").AsString(100).NotNullable()
           .WithColumn("Description").AsString(1000).Nullable()
           .WithColumn("InsertDate").AsDateTime().NotNullable()
           .WithColumn("InsertUserId").AsInt32().NotNullable()
           .WithColumn("UpdateDate").AsDateTime().Nullable()
           .WithColumn("UpdateUserId").AsInt32().Nullable()
           .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentMediaRatings", "Id", s => s
           .WithColumn("ContentId").AsInt32().NotNullable()
               .ForeignKey("Contents", "Id")
           .WithColumn("RatingId").AsInt32().NotNullable()
               .ForeignKey("ContentRatings", "Id")
           .WithColumn("Score").AsInt16().NotNullable()
           .WithColumn("UserId").AsInt32().NotNullable()
               .ForeignKey("Users", "UserId")
           .WithColumn("InsertDate").AsDateTime().NotNullable()
           .WithColumn("InsertUserId").AsInt32().NotNullable()
           .WithColumn("UpdateDate").AsDateTime().Nullable()
           .WithColumn("UpdateUserId").AsInt32().Nullable()
           .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("ContentCourse", "Id", s => s
          .WithColumn("ContentId").AsInt32().Nullable()
              .ForeignKey("Contents", "Id")
           .WithColumn("CourseId").AsInt32().NotNullable()
                .ForeignKey("Course", "Id")
           .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
           .WithColumn("SemesterId").AsInt32().NotNullable()
               .ForeignKey("Semester", "Id")
          .WithColumn("InsertDate").AsDateTime().NotNullable()
          .WithColumn("InsertUserId").AsInt32().NotNullable()
          .WithColumn("UpdateDate").AsDateTime().Nullable()
          .WithColumn("UpdateUserId").AsInt32().Nullable()
          .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("QuestionCourse", "Id", s => s
       .WithColumn("QuestionId").AsInt64().Nullable()
           .ForeignKey("Questions", "Id")
        .WithColumn("CourseId").AsInt32().NotNullable()
             .ForeignKey("Course", "Id")
        .WithColumn("ClassId").AsInt32().NotNullable()
             .ForeignKey("Classes", "Id")
        .WithColumn("SemesterId").AsInt32().NotNullable()
            .ForeignKey("Semester", "Id")
       .WithColumn("InsertDate").AsDateTime().NotNullable()
       .WithColumn("InsertUserId").AsInt32().NotNullable()
       .WithColumn("UpdateDate").AsDateTime().Nullable()
       .WithColumn("UpdateUserId").AsInt32().Nullable()
       .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));


    }
    public override void Down()
    {

    }
}
