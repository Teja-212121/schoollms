using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("States")]
[DisplayName("State"), InstanceName("State")]
[ReadPermission(PermissionKeys.MastersManagement.View)]
[ModifyPermission(PermissionKeys.MastersManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Masters.State")]
public sealed class StateRow : LoggingRow<StateRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty,LookupInclude]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Short Name"), Size(200), NotNull]
    public string ShortName { get => fields.ShortName[this]; set => fields.ShortName[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField ShortName;
        public BooleanField IsActive;

    }
}