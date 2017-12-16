// <copyright file="SyncResult.cs" company="companyPlaceholder">
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
    /// The <see cref="SyncResult"/>.
    /// </summary>
    public class SyncResult
    {
        public string ErrorMessage { get; set; }

        public bool Succeeded { get; set; }

        public SyncFolder SyncFolder { get; set; }

        public Webdav Webdav { get; set; }
    }
}
