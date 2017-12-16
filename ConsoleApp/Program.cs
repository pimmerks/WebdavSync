using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdavSync.ConsoleApp
{
    using log4net;
    using Runner;

    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Logger.Info("Console application started!");
            SyncRunner r = new SyncRunner();

            Console.ReadLine();
            Logger.Info("Console application closed!");
        }
    }
}
