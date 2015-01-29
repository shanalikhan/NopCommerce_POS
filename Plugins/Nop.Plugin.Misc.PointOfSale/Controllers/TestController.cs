using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Data;
using Nop.Plugin.Misc.PointOfSale.Domain;
using System.Web.Mvc;
namespace Nop.Plugin.Misc.PointOfSale.Controllers
{
    public class TestController : BasePluginController
    {
        
        public TestController(IRepository<Test> testRepo)
        {
            this.testRepo = testRepo;
        


        }

        public ActionResult Manage() {

            return View();

        }


        public IRepository<Test> testRepo { get; set; }
    }
}
