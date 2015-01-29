using Nop.Plugin.Misc.PointOfSale.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PointOfSale.Data
{
    public class TestRecord : EntityTypeConfiguration<Test>
    {
        public TestRecord(){

            HasKey(m => m.TestID);
            Property(m => m.TestID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



            }
    }
}
