using Nop.Web.Framework.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PointOfSale.Infrastructure
{
    public class ViewEngine : ThemeableRazorViewEngine
    {
        public ViewEngine() {

            ViewLocationFormats = new[] { "~/Plugins/Misc.PointOfSale/Views/{0}.cshtml" }; 
            PartialViewLocationFormats = new[] { "~/Plugins/Misc.PointOfSale/Views/{0}.cshtml" }; 

        }
    }
}
