using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MaintenanceMan
{
    [DependsOn(typeof(MaintenanceManCoreModule), typeof(AbpAutoMapperModule))]
    public class MaintenanceManApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
