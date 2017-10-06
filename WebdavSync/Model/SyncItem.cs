using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdavSync.Model
{
    public class SyncItem
    {
        public string Name { get; set; }

        public string LocalPath { get; set; }

        public string WebdavPath { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
