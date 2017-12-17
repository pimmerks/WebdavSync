// <copyright file="Config.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace WebdavSync.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="Webdav"/>.
    /// </summary>
    [Serializable]
    public class Webdav
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Webdav"/> class.
        /// </summary>
        public Webdav()
        {
            this.SyncFolders = new List<SyncFolder>();
        }

        public List<SyncFolder> SyncFolders { get; set; }
    }
}
