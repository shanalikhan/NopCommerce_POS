using Nop.Plugin.Misc.PointOfSale.Infrastructure;
using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
namespace Nop.Plugin.Misc.PointOfSale
{
    public class RouteConfig : IRouteProvider
    {
        public int Priority { get { return 0; } }




        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Misc.PointOfSale.ManageTest", "Test/Manage",
                new { controller = "Test" , action = "Manage" } ,
                new[] { "Nop.Plugin.Misc.Test.Controllers" }

                );


            routes.MapRoute("Plugin.Misc.PointOfSale.POSHome", "Mainpos/posIndex",
               new { controller = "MainPOS", action = "posindex" },
               new[] { "Nop.Plugin.Misc.Test.Controllers" }

               );
            //throw new NotImplementedException();
            ViewEngines.Engines.Insert(0, new ViewEngine()); ;
            // 0 put our engine to top priority

        }
    }
}
