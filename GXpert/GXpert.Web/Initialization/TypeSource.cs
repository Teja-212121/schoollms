using Serenity.Localization;
using System.Reflection;

namespace GXpert.AppServices;
public class TypeSource : DefaultTypeSource
{
    public TypeSource()
        : base(GetAssemblyList())
    {
    }

    private static Assembly[] GetAssemblyList()
    {
        return
        [
            typeof(LocalTextRegistry).Assembly,
            typeof(ISqlConnections).Assembly,
            typeof(IRow).Assembly,
            typeof(SaveRequestHandler<>).Assembly,
            typeof(IDynamicScriptManager).Assembly,
            typeof(EnvironmentSettings).Assembly,
            typeof(BackgroundJobManager).Assembly,
            typeof(Serenity.Pro.DataAuditLog.DataAuditLogPage).Assembly,
            typeof(Serenity.Pro.EmailQueue.EmailQueuePage).Assembly,
            typeof(Serenity.Pro.OpenIddict.OpenIdAuthorizationControllerBase).Assembly,
            typeof(Startup).Assembly
        ];
    }
}