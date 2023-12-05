using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Playlist;

[ConnectionKey("Default"), Module("Playlist"), TableName("PlayListContents")]
[DisplayName("Play List Content"), InstanceName("Play List Content")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class PlayListContentRow : Row<PlayListContentRow.RowFields>, IIdRow
{
    const string jPlayList = nameof(jPlayList);
    const string jContent = nameof(jContent);
    const string jExam = nameof(jExam);
    const string jLiveSession = nameof(jLiveSession);
    const string jAssignment = nameof(jAssignment);
    const string jModule = nameof(jModule);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Play List"), ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey("Contents", "Id"), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey("Exams", "Id"), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Live Session"), ForeignKey("LiveSessions", "Id"), LeftJoin(jLiveSession), TextualField(nameof(LiveSessionMeetingId))]
    public int? LiveSessionId { get => fields.LiveSessionId[this]; set => fields.LiveSessionId[this] = value; }

    [DisplayName("Assignment"), NotNull, ForeignKey("Assignments", "Id"), LeftJoin(jAssignment), TextualField(nameof(AssignmentTitle))]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Module"), ForeignKey("Modules", "Id"), LeftJoin(jModule), TextualField(nameof(ModuleTitle))]
    public int? ModuleId { get => fields.ModuleId[this]; set => fields.ModuleId[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("E Publish Status"), Column("ePublishStatus"), NotNull]
    public short? EPublishStatus { get => fields.EPublishStatus[this]; set => fields.EPublishStatus[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Content Title"), Expression($"{jContent}.[Title]")]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Exam Title"), Expression($"{jExam}.[Title]")]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Live Session Meeting Id"), Expression($"{jLiveSession}.[MeetingId]")]
    public string LiveSessionMeetingId { get => fields.LiveSessionMeetingId[this]; set => fields.LiveSessionMeetingId[this] = value; }

    [DisplayName("Assignment Title"), Expression($"{jAssignment}.[Title]")]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Module Title"), Expression($"{jModule}.[Title]")]
    public string ModuleTitle { get => fields.ModuleTitle[this]; set => fields.ModuleTitle[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field PlayListId;
        public Int32Field ContentId;
        public Int32Field ExamId;
        public Int32Field LiveSessionId;
        public Int32Field AssignmentId;
        public Int32Field ModuleId;
        public SingleField SortOrder;
        public Int16Field EPublishStatus;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField PlayListTitle;
        public StringField ContentTitle;
        public StringField ExamTitle;
        public StringField LiveSessionMeetingId;
        public StringField AssignmentTitle;
        public StringField ModuleTitle;
    }
}