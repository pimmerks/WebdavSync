namespace WebdavSync.Runner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net;
    using System.Net.Http;
    using System.Security;
    using System.Threading;
    using log4net;
    using Model;

    public class SyncRunner
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly SyncConfig webdavConfig;

        public SyncRunner(SyncConfig webdavConfig)
        {
            this.webdavConfig = webdavConfig;
            Logger.Info($"Creating sync runner with {webdavConfig.WebdavList.Count} webdav(s).");
        }

        public async Task<SyncResult> Sync()
        {
            Logger.Info("Starting sync");
            Thread.Sleep(1000);

            Logger.Info("Sync finished");

            return new SyncResult(this.webdavConfig);
        }
    }
}
