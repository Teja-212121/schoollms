using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("Questions")]
[DisplayName("Question"), InstanceName("Question")]
[ReadPermission(PermissionKeys.QuestionBankManagement.View)]
[ModifyPermission(PermissionKeys.QuestionBankManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("QuestionBank.Question")]
public sealed class QuestionRow : LoggingRow<QuestionRow.RowFields>, IIdRow, INameRow
{
    const string jQuestionCommonData = nameof(jQuestionCommonData);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);
    const string jBloomsIndex = nameof(jBloomsIndex);

    [DisplayName("Id"), Identity, IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question Text"), NotNull, QuickSearch, NameProperty, HtmlContentEditor(Rows = 3)]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }

    [DisplayName("Explaination"), HtmlContentEditor(Rows = 3)]
    public string Explaination { get => fields.Explaination[this]; set => fields.Explaination[this] = value; }

    [DisplayName("Is Subjective"), NotNull]
    public bool? IsSubjective { get => fields.IsSubjective[this]; set => fields.IsSubjective[this] = value; }

    [DisplayName("E Question Type"), NotNull]
    public EQuestionType? EQuestionType { get => (EQuestionType?)fields.EQuestionType[this]; set => fields.EQuestionType[this] = (short?)value; }

    [DisplayName("E Difficulty Level"), NotNull]
    public EDifficultyLevel? EDifficultyLevel { get => (EDifficultyLevel?)fields.EDifficultyLevel[this]; set => fields.EDifficultyLevel[this] = (short?)value; }

    [DisplayName("Question Common Data"), ForeignKey(typeof(CommonDataRow)), LeftJoin(jQuestionCommonData)]
    [TextualField(nameof(QuestionCommonDataCommonDataTitle)), ServiceLookupEditor(typeof(CommonDataRow))]
    public int? QuestionCommonDataId { get => fields.QuestionCommonDataId[this]; set => fields.QuestionCommonDataId[this] = value; }

    [DisplayName("Question Common Data Sort Order")]
    public float? QuestionCommonDataSortOrder { get => fields.QuestionCommonDataSortOrder[this]; set => fields.QuestionCommonDataSortOrder[this] = value; }

    [DisplayName("Class"), ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject", CascadeFrom = "ClassId", CascadeField = "ClassId")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic)]
    [LookupEditor("Syllabus.Topic", CascadeFrom = "SubjectId", CascadeField = "SubjectId")]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Blooms Index"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsIndex)]
    [TextualField(nameof(BloomsIndexCoginitiveSkill))]
    [LookupEditor("Masters.BloomsTaxanomy")]
    public int? BloomsIndex { get => fields.BloomsIndex[this]; set => fields.BloomsIndex[this] = value; }

    [DisplayName("Blooms Weightage")]
    public float? BloomsWeightage { get => fields.BloomsWeightage[this]; set => fields.BloomsWeightage[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]

    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Question Common Data Common Data Title"), Origin(jQuestionCommonData, nameof(CommonDataRow.CommonDataTitle))]
    public string QuestionCommonDataCommonDataTitle { get => fields.QuestionCommonDataCommonDataTitle[this]; set => fields.QuestionCommonDataCommonDataTitle[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }

    [DisplayName("Blooms Index Coginitive Skill"), Expression($"{jBloomsIndex}.[CoginitiveSkill]")]
    public string BloomsIndexCoginitiveSkill { get => fields.BloomsIndexCoginitiveSkill[this]; set => fields.BloomsIndexCoginitiveSkill[this] = value; }

    [DisplayName("Question Option"), MasterDetailRelation(foreignKey: nameof(QuestionOptionRow.QuestionId)),  NotMapped, NotNull]
    public List<QuestionOptionRow> QuestionOptions
    {
        get { return Fields.QuestionOptions[this]; }
        set { Fields.QuestionOptions[this] = value; }
    }

    public class RowFields : LoggingRowFields
    {
        public Int64Field Id;
        public StringField QuestionText;
        public StringField Explaination;
        public BooleanField IsSubjective;
        public Int16Field EQuestionType;
        public Int16Field EDifficultyLevel;
        public Int32Field QuestionCommonDataId;
        public SingleField QuestionCommonDataSortOrder;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public Int32Field TopicId;
        public Int32Field BloomsIndex;
        public SingleField BloomsWeightage;
        public BooleanField IsActive;

        public StringField QuestionCommonDataCommonDataTitle;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField TopicTitle;
        public StringField BloomsIndexCoginitiveSkill;
        public RowListField<QuestionOptionRow> QuestionOptions;


    }
}