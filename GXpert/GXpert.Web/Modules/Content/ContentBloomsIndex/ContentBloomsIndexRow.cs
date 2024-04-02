using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentBloomsIndex")]
[DisplayName("Content Blooms Index"), InstanceName("Content Blooms Index")]
[ReadPermission(PermissionKeys.ContentManagement.View)]
[ModifyPermission(PermissionKeys.ContentManagement.View)]
public sealed class ContentBloomsIndexRow : LoggingRow<ContentBloomsIndexRow.RowFields>, IIdRow
{
    const string jContent = nameof(jContent);
    const string jBloomsIndex = nameof(jBloomsIndex);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [ServiceLookupEditor(typeof(ContentRow))]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Blooms Index"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsIndex)]
    [TextualField(nameof(BloomsIndexCoginitiveSkill))]
    [LookupEditor("Masters.BloomsTaxanomy")]
    public int? BloomsIndex { get => fields.BloomsIndex[this]; set => fields.BloomsIndex[this] = value; }

    [DisplayName("Weightage")]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Blooms Index Coginitive Skill"), Expression($"{jBloomsIndex}.[CoginitiveSkill]")]
    public string BloomsIndexCoginitiveSkill { get => fields.BloomsIndexCoginitiveSkill[this]; set => fields.BloomsIndexCoginitiveSkill[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ContentId;
        public Int32Field BloomsIndex;
        public SingleField Weightage;
        public BooleanField IsActive;

        public StringField ContentTitle;
        public StringField BloomsIndexCoginitiveSkill;
    }
}