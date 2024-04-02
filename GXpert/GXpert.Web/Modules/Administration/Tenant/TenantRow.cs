using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GXpert.Administration;

[ConnectionKey("Default"), Module("Administration"), TableName("Tenants")]
[DisplayName("Tenant"), InstanceName("Tenant")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class TenantRow : Row<TenantRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Tenant Id"), Identity, IdProperty]
    public int? TenantId { get => fields.TenantId[this]; set => fields.TenantId[this] = value; }

    [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string TenantName { get => fields.TenantName[this]; set => fields.TenantName[this] = value; }

    [DisplayName("Owner Id")]
    public int? OwnerId { get => fields.OwnerId[this]; set => fields.OwnerId[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field TenantId;
        public StringField TenantName;
        public Int32Field OwnerId;

    }
}