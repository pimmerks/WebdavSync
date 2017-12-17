using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdavSync.ConsoleApp
{
    using log4net;
    using Model;
    using Runner;
    using Config;

    public class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Config.Save(new SyncConfig());
            Logger.Info("Console application started!");
            Start();
            Logger.Info("Console application finished!");
#if DEBUG
            Console.ReadLine();
#endif
        }

        private static void Start()
        {
            var config = Config.Load();

            if (config == null)
            {
                Logger.Error("Config file was empty! Stopping program!");
                return;
            }

            var runner = new SyncRunner(config);

            Logger.Info("Starting sync task");

            var task = runner.Sync();
            task.Wait();

            Logger.Info("Sync task stopped!");

            LogResult(task.Result);
        }

        private static void LogResult(SyncResult result)
        {
            Logger.Info(result);
        }
    }
}
