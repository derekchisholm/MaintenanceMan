using Abp.Web.Mvc.Views;

namespace MaintenanceMan.Web.Views
{
    public abstract class MaintenanceManWebViewPageBase : MaintenanceManWebViewPageBase<dynamic>
    {

    }

    public abstract class MaintenanceManWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MaintenanceManWebViewPageBase()
        {
            LocalizationSourceName = MaintenanceManConsts.LocalizationSourceName;
        }
    }
}