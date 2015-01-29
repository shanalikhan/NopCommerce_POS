using Nop.Core.Data;
using Nop.Plugin.Misc.PointOfSale.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PointOfSale.Domain
{
    public class ViewTestService : ITestService
    {
         private readonly IRepository<Test> testRepo;

        public ViewTestService(IRepository<Test> testRepo)
        {
            this.testRepo = testRepo;
        }

        /// <summary>
        /// Logs the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void Log(Test record)
        {
            testRepo.Insert(record);
        }
    }
}
