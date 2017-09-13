using System.Web;
using System.Web.Http;
using DogsVsCatsWeb.App_Start;

namespace DogsVsCatsWeb
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        { 
            GlobalConfiguration.Configure(WebApiConfig.Register);            
        }
    }
}