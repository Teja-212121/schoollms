using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Skills;

[ConnectionKey("Default"), Module("Skills"), TableName("Skills")]
[DisplayName("Skills"), InstanceName("Skill")]
[ReadPermission(PermissionKeys.SkillsManagement.View)]
[ModifyPermission(PermissionKeys.SkillsManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Skills.Skill")]
public sealed class SkillRow : LoggingRow<SkillRow.RowFields>, IIdRow, INameRow
{
    const string jSkillCategory = nameof(jSkillCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Skill Category"), NotNull, ForeignKey("SkillCategory", "Id"), LeftJoin(jSkillCategory)]
    [TextualField(nameof(SkillCategoryName))]
    [LookupEditor("Skills.SkillCategory")]
    public int? SkillCategoryId { get => fields.SkillCategoryId[this]; set => fields.SkillCategoryId[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Skill Category Name"), Expression($"{jSkillCategory}.[Name]")]
    public string SkillCategoryName { get => fields.SkillCategoryName[this]; set => fields.SkillCategoryName[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public Int32Field SkillCategoryId;
        public BooleanField IsActive;

        public StringField SkillCategoryName;
    }
}