using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("Branch")]
[DisplayName("Branch"), InstanceName("Branch")]
[ReadPermission(PermissionKeys.InstituteManagement.View)]
[ModifyPermission(PermissionKeys.InstituteManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Institute.Branch")]
public sealed class BranchRow : LoggingRow<BranchRow.RowFields>, IIdRow, INameRow
{
    const string jInstitute = nameof(jInstitute);
    const string jDepartment = nameof(jDepartment);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Institute"), NotNull, ForeignKey(typeof(InstituteRow)), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    [ServiceLookupEditor(typeof(InstituteRow), Service = "Institute/Institute/List")]
    
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    [DisplayName("Department"), NotNull, ForeignKey("Departments", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentTitle))]
    [LookupEditor("Institute.Department")]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Institute Name"), Origin(jInstitute, nameof(InstituteRow.Name))]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }

    [DisplayName("Department Title"), Expression($"{jDepartment}.[Title]")]
    public string DepartmentTitle { get => fields.DepartmentTitle[this]; set => fields.DepartmentTitle[this] = value; }

    [DisplayName("Branch Code")]
    public int? BranchCode { get => fields.BranchCode[this]; set => fields.BranchCode[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public Int32Field InstituteId;
        public Int32Field DepartmentId;
        public StringField Description;
        public Int32Field BranchCode;
        public BooleanField IsActive;

        public StringField InstituteName;
        public StringField DepartmentTitle;
    }
}