namespace GXpert.Modules.Administration.Tenant;

public class MultiTenantRow
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}
