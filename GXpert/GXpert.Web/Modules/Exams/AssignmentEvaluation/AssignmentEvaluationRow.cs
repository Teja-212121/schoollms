﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("AssignmentEvaluation")]
[DisplayName("Assignment Evaluation"), InstanceName("Assignment Evaluation")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class AssignmentEvaluationRow : Row<AssignmentEvaluationRow.RowFields>, IIdRow, INameRow
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
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), NotNull, ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Blooms Index"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsIndex)]
    [TextualField(nameof(BloomsIndexCoginitiveSkill))]
    public int? BloomsIndex { get => fields.BloomsIndex[this]; set => fields.BloomsIndex[this] = value; }

    [DisplayName("Blooms Weightage")]
    public float? BloomsWeightage { get => fields.BloomsWeightage[this]; set => fields.BloomsWeightage[this] = value; }

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

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field AssignmentId;
        public StringField EvalutionCriteria;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public Int32Field TopicId;
        public Int32Field BloomsIndex;
        public SingleField BloomsWeightage;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField AssignmentTitle;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField TopicTitle;
        public StringField BloomsIndexCoginitiveSkill;
    }
}