// <copyright file="SyncFolder.cs" company="companyPlaceholder">
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
    /// The <see cref="SyncFolder"/>.
    /// </summary>
    [Serializable]
    public class SyncFolder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncFolder"/> class.
        /// </summary>
        public SyncFolder()
        {

        }

        public string Name { get; set; }
        public string LocalPath { get; set; }
        public string WebdavPath { get; set; }
    }
}
