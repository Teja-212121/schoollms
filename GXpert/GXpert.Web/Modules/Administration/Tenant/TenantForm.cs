using Serenity.ComponentModel;

namespace GXpert.Administration.Forms;

[FormScript("Administration.Tenant")]
[BasedOnRow(typeof(TenantRow), CheckNames = true)]
public class TenantForm
{
    public string TenantName { get; set; }
    public int OwnerId { get; set; }
}