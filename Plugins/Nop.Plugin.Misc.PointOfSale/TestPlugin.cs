using Nop.Core.Data;
using Nop.Core.Plugins;
using Nop.Plugin.Misc.PointOfSale.Data;
using Nop.Plugin.Misc.PointOfSale.Domain;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PointOfSale
{
    class TestPlugin : BasePlugin , IAdminMenuPlugin
    {

        public TestPlugin(POSContext context , IRepository<Test> testrepo)
        {

            this.context = context;
            this.testRepo = testrepo;

        }

        public bool Authenticate()
        {
            return true;
        }


        public override void Install()
        {
            context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            context.Uninstall();

            base.Uninstall();
        }

        public SiteMapNode BuildMenuItem()
        {
            SiteMapNode child1 = new SiteMapNode { 
            
                Visible = true ,
                Title = "Child 1",
                Url = "/Test/Manage"

            };

            List<SiteMapNode> children= new List<SiteMapNode>();
            children.Add(child1);

            SiteMapNode node = new SiteMapNode{
        
            Visible = true , 
            Title = "Point Of Sale" , 
            Url = "/Mainpos/posindex"
            
        };
            node.ChildNodes.Add(child1);
            return node;

            //throw new NotImplementedException();
        }

        public POSContext context { get; set; }

        public IRepository<Test> testRepo { get; set; }
    }
}
