using FluentValidation.Mvc;
using FluentValidationMVC.Validation;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FluentValidationMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ValidationConfiguration();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void ValidationConfiguration()
        {
            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new ValidatorFactory();
            });
        }
    }
}
