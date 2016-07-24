using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MaintenanceMan.EntityFramework;

namespace MaintenanceMan.Migrator
{
    [DependsOn(typeof(MaintenanceManDataModule))]
    public class MaintenanceManMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MaintenanceManDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}