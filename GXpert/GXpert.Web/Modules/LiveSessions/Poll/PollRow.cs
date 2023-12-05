using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions;

[ConnectionKey("Default"), Module("LiveSessions"), TableName("Polls")]
[DisplayName("Poll"), InstanceName("Poll"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class PollRow : Row<PollRow.RowFields>, IIdRow, INameRow
{
    const string jLiveSessionLog = nameof(jLiveSessionLog);
    const string jBloomsTaxonomy = nameof(jBloomsTaxonomy);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Question { get => fields.Question[this]; set => fields.Question[this] = value; }

    [DisplayName("E Question Type"), Column("eQuestionType"), NotNull]
    public short? EQuestionType { get => fields.EQuestionType[this]; set => fields.EQuestionType[this] = value; }

    [DisplayName("Option1"), Size(500), NotNull]
    public string Option1 { get => fields.Option1[this]; set => fields.Option1[this] = value; }

    [DisplayName("Option2"), Size(500), NotNull]
    public string Option2 { get => fields.Option2[this]; set => fields.Option2[this] = value; }

    [DisplayName("Option3"), Size(500)]
    public string Option3 { get => fields.Option3[this]; set => fields.Option3[this] = value; }

    [DisplayName("Option4"), Size(500)]
    public string Option4 { get => fields.Option4[this]; set => fields.Option4[this] = value; }

    [DisplayName("Option5"), Size(500)]
    public string Option5 { get => fields.Option5[this]; set => fields.Option5[this] = value; }

    [DisplayName("Right Answer"), Size(500)]
    public string RightAnswer { get => fields.RightAnswer[this]; set => fields.RightAnswer[this] = value; }

    [DisplayName("Live Session Log"), ForeignKey(typeof(LiveSessionLogRow)), LeftJoin(jLiveSessionLog)]
    [ServiceLookupEditor(typeof(LiveSessionLogRow))]
    public int? LiveSessionLogId { get => fields.LiveSessionLogId[this]; set => fields.LiveSessionLogId[this] = value; }

    [DisplayName("Total Attempts"), NotNull]
    public short? TotalAttempts { get => fields.TotalAttempts[this]; set => fields.TotalAttempts[this] = value; }

    [DisplayName("Average Response Time"), NotNull]
    public float? AverageResponseTime { get => fields.AverageResponseTime[this]; set => fields.AverageResponseTime[this] = value; }

    [DisplayName("Number Of Correct"), NotNull]
    public short? NumberOfCorrect { get => fields.NumberOfCorrect[this]; set => fields.NumberOfCorrect[this] = value; }

    [DisplayName("Number Of Wrong"), NotNull]
    public short? NumberOfWrong { get => fields.NumberOfWrong[this]; set => fields.NumberOfWrong[this] = value; }

    [DisplayName("Blooms Taxonomy"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsTaxonomy)]
    [TextualField(nameof(BloomsTaxonomyCoginitiveSkill))]
    public int? BloomsTaxonomyId { get => fields.BloomsTaxonomyId[this]; set => fields.BloomsTaxonomyId[this] = value; }

    [DisplayName("Weightage"), NotNull]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

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

    [DisplayName("Blooms Taxonomy Coginitive Skill"), Expression($"{jBloomsTaxonomy}.[CoginitiveSkill]")]
    public string BloomsTaxonomyCoginitiveSkill { get => fields.BloomsTaxonomyCoginitiveSkill[this]; set => fields.BloomsTaxonomyCoginitiveSkill[this] = value; }
}