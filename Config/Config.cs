// <copyright file="Config.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace WebdavSync.Config
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Remoting.Channels;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;
    using log4net;
    using WebdavSync.Model;

    /// <summary>
    /// The <see cref="Config"/>.
    /// </summary>
    public static class Config
    {
        private static readonly string Path = new Uri(
            System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\\webdav.config")
            .LocalPath;

        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static SyncConfig Load()
        {
            Logger.Debug("Loading configuration file.");
            if (!File.Exists(Path))
            {
                Logger.Warn($"The file does not exist: {Path}");
                // Create file
                File.Create(Path).Close();
            }

            var formatter = new BinaryFormatter();
            var fs = new FileStream(Path, FileMode.Open);
            SyncConfig result = null;

            try
            {
                result = formatter.Deserialize(fs) as SyncConfig;
            }
            catch (Exception e)
            {
                Logger.Error($"Exception thrown while desirializing the file: {Path}", e);
            }
            finally
            {
                fs.Close();
            }

            return result;
        }

        public static bool Save(SyncConfig config)
        {
            Logger.Debug("Saving configuration file.");
            if (!File.Exists(Path))
            {
                Logger.Warn($"The file does not exist: {Path}");
            }

            var formatter = new BinaryFormatter();
            var fs = new FileStream(Path, FileMode.Open);

            try
            {
                formatter.Serialize(fs, config);
            }
            catch (Exception e)
            {
                Logger.Error($"Exception thrown while desirializing the file: {Path}", e);
                return false;
            }
            finally
            {
                fs.Close();
            }

            return true;
        }
    }
}
