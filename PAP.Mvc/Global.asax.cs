using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PAP.DataAccess;
using PAP.Repositories;

namespace PAP.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BookRepository repo = new BookRepository();

            // carga los libros si todavia no estan todos
            if (repo.GetAll().Count() < 50)
            {
                // borra Ancient Roads (Id 16) para que no quede duplicado
                repo.Delete(16);

                DataAccessLayer dal = new DataAccessLayer();
                repo.AddMany(dal.GetSeedBooks());
            }
        }
    }
}