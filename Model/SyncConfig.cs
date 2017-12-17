// <copyright file="SyncConfig.cs" company="companyPlaceholder">
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
    /// The <see cref="SyncConfig"/>.
    /// </summary>
    [Serializable]
    public class SyncConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncConfig"/> class.
        /// </summary>
        public SyncConfig()
        {
            this.WebdavList = new List<Webdav>();
        }

        public List<Webdav> WebdavList { get; set; }
    }
}
