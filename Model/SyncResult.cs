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
    [Serializable]
    public class SyncResult
    {
        public SyncResult(SyncConfig configConfig)
        {
            this.Config = configConfig;
        }

        public string ErrorMessage { get; set; }

        public bool Succeeded { get; set; }

        public SyncConfig Config { get; }
    }
}
