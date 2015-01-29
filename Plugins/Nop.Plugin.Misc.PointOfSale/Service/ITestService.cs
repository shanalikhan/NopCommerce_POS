using Nop.Plugin.Misc.PointOfSale.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PointOfSale.Service
{
    public interface ITestService
    {
      
            /// <summary>
            /// Add the specified record.
            /// </summary>
            /// <param name="record">The record.</param>
            void Log(Test item);
       
    }
}
