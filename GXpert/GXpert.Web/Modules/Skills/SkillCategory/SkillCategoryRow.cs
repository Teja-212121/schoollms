using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Skills;

[ConnectionKey("Default"), Module("Skills"), TableName("SkillCategory")]
[DisplayName("Skill Category"), InstanceName("Skill Category")]
[ReadPermission(PermissionKeys.SkillsManagement.View)]
[ModifyPermission(PermissionKeys.SkillsManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Skills.SkillCategory")]
public sealed class SkillCategoryRow : LoggingRow<SkillCategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        
        public BooleanField IsActive;

    }
}