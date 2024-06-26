using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("Departments")]
[DisplayName("Department"), InstanceName("Department")]
[ReadPermission(PermissionKeys.InstituteManagement.View)]
[ModifyPermission(PermissionKeys.InstituteManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Institute.Department")]
public sealed class DepartmentRow : LoggingRow<DepartmentRow.RowFields>, IIdRow, INameRow
{
    const string jInstitute = nameof(jInstitute);
    const string jHod = nameof(jHod);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Institute"), NotNull, ForeignKey(typeof(InstituteRow)), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    [ServiceLookupEditor(typeof(InstituteRow), Service = "Institute/Institute/List")]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    [DisplayName("HOD"), NotNull, ForeignKey("Hod", "Id"), LeftJoin(jHod), TextualField(nameof(HODName))]
    [LookupEditor("Users.Hod", InplaceAdd = true)]
    public int? HodId { get => fields.HodId[this]; set => fields.HodId[this] = value; }
    

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Institute Name"), Origin(jInstitute, nameof(InstituteRow.Name))]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }

    [DisplayName("HOD Name"), Expression($"{jHod}.[Name]")]
    public string HODName { get => fields.HODName[this]; set => fields.HODName[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public Int32Field InstituteId;
        public Int32Field HodId;
        public StringField Description;
       
        public BooleanField IsActive;

        public StringField InstituteName;
        public StringField HODName;
    }
}