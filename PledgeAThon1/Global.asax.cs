using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using PledgeAThon1.IoC;

namespace PledgeAThon1
{
    
    
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
       
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Init IoC
            //InitContainer();
            //ControllerBuilder.Current.SetControllerFactory(typeof(UnityControllerFactory));
            Bootstrapper.Run();

            //initialize database
            InitDatabase();
        }

        private void InitDatabase()
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            //db = new Context();
            //db.Database.Initialize(true);
        }



        #region IoC Stuff

        //private static IUnityContainer _container;

        ///// <summary>
        ///// The Unity container for the current application
        ///// </summary>
        //public static IUnityContainer Container
        //{
        //    get { return _container; }
        //}


        //IUnityContainer IContainerProvider.Container
        //{
        //    get { return Container; }
        //}

        //private static void InitContainer()
        //{
        //    if (_container == null)
        //    {
        //        _container = new UnityContainer();
        //    }

        //    // Register the relevant types for the 
        //    // container here through classes or configuration
        //    //_container.RegisterType<IMessageService, MessageService>();
        //}

        //private static void CleanUp()
        //{
        //    if (Container != null)
        //    {
        //        Container.Dispose();
        //    }
        //}

        #endregion


    }
}