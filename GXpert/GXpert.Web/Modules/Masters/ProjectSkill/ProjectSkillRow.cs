using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("ProjectSkills")]
[DisplayName("Project Skill"), InstanceName("Project Skill")]
[ReadPermission(PermissionKeys.MastersManagement.View)]
[ModifyPermission(PermissionKeys.MastersManagement.Modify)]
public sealed class ProjectSkillRow : Row<ProjectSkillRow.RowFields>, IIdRow
{
    const string jSkillCategory = nameof(jSkillCategory);
    const string jSkill = nameof(jSkill);
    const string jProject = nameof(jProject);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Skill Category"), ForeignKey(typeof(Skills.SkillCategoryRow)), LeftJoin(jSkillCategory)]
    [TextualField(nameof(SkillCategoryName)), LookupEditor(typeof(Skills.SkillCategoryRow), Async = true)]
    public int? SkillCategoryId { get => fields.SkillCategoryId[this]; set => fields.SkillCategoryId[this] = value; }

    [DisplayName("Skill"), ForeignKey(typeof(Skills.SkillRow)), LeftJoin(jSkill), TextualField(nameof(SkillName))]
    [LookupEditor(typeof(Skills.SkillRow), Async = true)]
    public int? SkillId { get => fields.SkillId[this]; set => fields.SkillId[this] = value; }

    [DisplayName("Project"), ForeignKey("Projects", "Id"), LeftJoin(jProject), TextualField(nameof(ProjectTitle))]
    public int? ProjectId { get => fields.ProjectId[this]; set => fields.ProjectId[this] = value; }

    [DisplayName("Skill Category Name"), Origin(jSkillCategory, nameof(Skills.SkillCategoryRow.Name))]
    public string SkillCategoryName { get => fields.SkillCategoryName[this]; set => fields.SkillCategoryName[this] = value; }

    [DisplayName("Skill Name"), Origin(jSkill, nameof(Skills.SkillRow.Name))]
    public string SkillName { get => fields.SkillName[this]; set => fields.SkillName[this] = value; }

    [DisplayName("Project Title"), Expression($"{jProject}.[Title]")]
    public string ProjectTitle { get => fields.ProjectTitle[this]; set => fields.ProjectTitle[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field SkillCategoryId;
        public Int32Field SkillId;
        public Int32Field ProjectId;

        public StringField SkillCategoryName;
        public StringField SkillName;
        public StringField ProjectTitle;
    }
}