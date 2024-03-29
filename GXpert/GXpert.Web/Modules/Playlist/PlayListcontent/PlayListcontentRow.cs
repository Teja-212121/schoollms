using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Playlist;

[ConnectionKey("Default"), Module("Playlist"), TableName("PlayListContents")]
[DisplayName("Play List Content"), InstanceName("Play List Content")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript("Playlist.PlayListContent")]
public sealed class PlayListContentRow : LoggingRow<PlayListContentRow.RowFields>, IIdRow
{
    const string jPlayList = nameof(jPlayList);
    const string jContent = nameof(jContent);
    const string jExam = nameof(jExam);
    const string jLiveSession = nameof(jLiveSession);
    const string jAssignment = nameof(jAssignment);
    const string jModule = nameof(jModule);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("E Content Type"), Column("eContentType")]
    public EPlayListContentType? EContentType { get => (EPlayListContentType?)fields.EContentType[this]; set => fields.EContentType[this] = (short?)value; }

    [DisplayName("Play List"), ForeignKey(typeof(PlayListRow)), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Content"), ForeignKey(typeof(Content.ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor("Content.Content")]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Exam"), ForeignKey(typeof(Exams.ExamRow)), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [LookupEditor("Exams.Exam")]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Live Session"), ForeignKey(typeof(LiveSessions.LiveSessionRow)), LeftJoin(jLiveSession)]
    [TextualField(nameof(LiveSessionMeetingId))]
    [LookupEditor("LiveSessions.LiveSession")]
    public int? LiveSessionId { get => fields.LiveSessionId[this]; set => fields.LiveSessionId[this] = value; }

    [DisplayName("Assignment"), ForeignKey(typeof(Exams.AssignmentRow)), LeftJoin(jAssignment)]
    [TextualField(nameof(AssignmentTitle))]
    [LookupEditor("Exams.Assignment")]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Module"), ForeignKey(typeof(ModuleRow)), LeftJoin(jModule), TextualField(nameof(ModuleTitle))]
    [ServiceLookupEditor(typeof(ModuleRow))]
    public int? ModuleId { get => fields.ModuleId[this]; set => fields.ModuleId[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("E Publish Status"), Column("ePublishStatus"), NotNull]
    public EExamStatus? EPublishStatus { get => (EExamStatus)fields.EPublishStatus[this]; set => fields.EPublishStatus[this] = (short?)value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Origin(jPlayList, nameof(PlayListRow.Title))]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(Content.ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Exam Title"), Origin(jExam, nameof(Exams.ExamRow.Title))]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Live Session Meeting Id"), Origin(jLiveSession, nameof(LiveSessions.LiveSessionRow.MeetingId))]
    public string LiveSessionMeetingId { get => fields.LiveSessionMeetingId[this]; set => fields.LiveSessionMeetingId[this] = value; }

    [DisplayName("Assignment Title"), Origin(jAssignment, nameof(Exams.AssignmentRow.Title))]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Module Title"), Origin(jModule, nameof(ModuleRow.Title))]
    public string ModuleTitle { get => fields.ModuleTitle[this]; set => fields.ModuleTitle[this] = value; }
    [NotMapped]
    public String RowIds
    {
        get => fields.RowIds[this];
        set => fields.RowIds[this] = value;
    }
    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int16Field EContentType;
        public Int32Field PlayListId;
        public Int32Field ContentId;
        public Int32Field ExamId;
        public Int32Field LiveSessionId;
        public Int32Field AssignmentId;
        public Int32Field ModuleId;
        public SingleField SortOrder;
        public Int16Field EPublishStatus;
        public BooleanField IsActive;

        public StringField PlayListTitle;
        public StringField ContentTitle;
        public StringField ExamTitle;
        public StringField LiveSessionMeetingId;
        public StringField AssignmentTitle;
        public StringField ModuleTitle;
        public StringField RowIds;
    }
}