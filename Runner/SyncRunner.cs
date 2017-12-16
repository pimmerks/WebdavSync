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
        public bool IsRunning { get; set; }

        public SyncRunner()
        {

        }

        public async Task<SyncResult> Sync(SyncFolder folder)
        {
            throw new NotImplementedException();
        }

        public async Task<Dictionary<SyncFolder, SyncResult>> SyncMultple(List<SyncFolder> syncFolders)
        {
            var result = new Dictionary<SyncFolder, SyncResult>();

            foreach (var syncFolder in syncFolders)
            {
                result.Add(syncFolder, await this.Sync(syncFolder));
            }

            return result;
        }
    }
}
