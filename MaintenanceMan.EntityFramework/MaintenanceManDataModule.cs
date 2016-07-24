using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MaintenanceMan.EntityFramework;

namespace MaintenanceMan
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MaintenanceManCoreModule))]
    public class MaintenanceManDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MaintenanceManDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
