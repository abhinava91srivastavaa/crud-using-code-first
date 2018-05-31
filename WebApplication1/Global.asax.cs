using System.Web.Http;

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration;
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
