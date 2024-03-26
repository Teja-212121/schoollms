using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("UserSkillsScore")]
[DisplayName("User Skills Score"), InstanceName("User Skills Score")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class UserSkillsScoreRow : Row<UserSkillsScoreRow.RowFields>, IIdRow
{
    const string jSkillCategory = nameof(jSkillCategory);
    const string jSkill = nameof(jSkill);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Skill Category"), ForeignKey(typeof(Skills.SkillCategoryRow)), LeftJoin(jSkillCategory)]
    [TextualField(nameof(SkillCategoryName)), LookupEditor(typeof(Skills.SkillCategoryRow), Async = true)]
    public int? SkillCategoryId { get => fields.SkillCategoryId[this]; set => fields.SkillCategoryId[this] = value; }

    [DisplayName("Skill"), ForeignKey(typeof(Skills.SkillRow)), LeftJoin(jSkill), TextualField(nameof(SkillName))]
    [LookupEditor(typeof(Skills.SkillRow), Async = true)]
    public int? SkillId { get => fields.SkillId[this]; set => fields.SkillId[this] = value; }

    [DisplayName("Score")]
    public float? Score { get => fields.Score[this]; set => fields.Score[this] = value; }


    [DisplayName("Skill Category Name"), Origin(jSkillCategory, nameof(Skills.SkillCategoryRow.Name))]
    public string SkillCategoryName { get => fields.SkillCategoryName[this]; set => fields.SkillCategoryName[this] = value; }

    [DisplayName("Skill Name"), Origin(jSkill, nameof(Skills.SkillRow.Name))]
    public string SkillName { get => fields.SkillName[this]; set => fields.SkillName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field SkillCategoryId;
        public Int32Field SkillId;
        public SingleField Score;
        public StringField SkillCategoryName;
        public StringField SkillName;
    }
}