using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("AssignmentEvaluation")]
[DisplayName("Assignment Evaluation"), InstanceName("Assignment Evaluation")]
[ReadPermission(PermissionKeys.ExamsManagement.View)]
[ModifyPermission(PermissionKeys.ExamsManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Exams.AssignmentEvaluation")]
public sealed class AssignmentEvaluationRow : LoggingRow<AssignmentEvaluationRow.RowFields>, IIdRow, INameRow
{
    const string jAssignment = nameof(jAssignment);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);
    const string jBloomsIndex = nameof(jBloomsIndex);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Assignment"), NotNull, ForeignKey(typeof(AssignmentRow)), LeftJoin(jAssignment), TextualField(nameof(AssignmentTitle))]
    [ServiceLookupEditor(typeof(AssignmentRow))]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Evalution Criteria"), Size(1000), NotNull, QuickSearch, NameProperty]
    public string EvalutionCriteria { get => fields.EvalutionCriteria[this]; set => fields.EvalutionCriteria[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), NotNull, ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    [LookupEditor("Syllabus.Topic")]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Blooms Index"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsIndex)]
    [TextualField(nameof(BloomsIndexCoginitiveSkill))]
    [LookupEditor("Masters.BloomsTaxanomy")]
    public int? BloomsIndex { get => fields.BloomsIndex[this]; set => fields.BloomsIndex[this] = value; }

    [DisplayName("Blooms Weightage")]
    public float? BloomsWeightage { get => fields.BloomsWeightage[this]; set => fields.BloomsWeightage[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Assignment Title"), Origin(jAssignment, nameof(AssignmentRow.Title))]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }

    [DisplayName("Blooms Index Coginitive Skill"), Expression($"{jBloomsIndex}.[CoginitiveSkill]")]
    public string BloomsIndexCoginitiveSkill { get => fields.BloomsIndexCoginitiveSkill[this]; set => fields.BloomsIndexCoginitiveSkill[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field AssignmentId;
        public StringField EvalutionCriteria;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public Int32Field TopicId;
        public Int32Field BloomsIndex;
        public SingleField BloomsWeightage;
        public BooleanField IsActive;

        public StringField AssignmentTitle;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField TopicTitle;
        public StringField BloomsIndexCoginitiveSkill;
    }
}