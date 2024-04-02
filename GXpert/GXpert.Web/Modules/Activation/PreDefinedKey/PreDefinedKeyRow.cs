using Rio.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("PreDefinedKeys")]
[DisplayName("Pre Defined Key"), InstanceName("Pre Defined Key")]
[ReadPermission(PermissionKeys.ActivationManagement.View)]
[ModifyPermission(PermissionKeys.ActivationManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class PreDefinedKeyRow : LoggingRow<PreDefinedKeyRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Serial Key"), Size(100), NotNull, QuickSearch, NameProperty]
    public string SerialKey { get => fields.SerialKey[this]; set => fields.SerialKey[this] = value; }

    [DisplayName("E Status"), Column("eStatus")]
    public EPreDefinedKeyStatus? EStatus { get => (EPreDefinedKeyStatus?)fields.EStatus[this]; set => fields.EStatus[this] = (short?)value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField SerialKey;
        public Int16Field EStatus;
        public Int16Field IsActive;

    }
}