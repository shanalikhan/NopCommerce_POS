using Nop.Services.Catalog;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Nop.Plugin.Misc.PointOfSale.Controllers
{
    public class MainPOSController : BasePluginController
    {
        private IProductService productService;

        public MainPOSController(IProductService service) {

            this.productService = service;
        }

        public ActionResult posindex() {

            return View();
        }
        [HttpPost]
        public JsonResult GetAllProducts(string startWith)
        {
                        
          
          var results = productService.SearchProducts(keywords:startWith);
          var list = JsonConvert.SerializeObject(results.Select(m => new { id=m.Id , label = m.Name }).ToList());
            return Json(list);

        }


    }
}
