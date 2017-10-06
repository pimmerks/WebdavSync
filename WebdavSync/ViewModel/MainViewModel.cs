using GalaSoft.MvvmLight;
using System.Collections.Generic;
using WebdavSync.Model;

namespace WebdavSync.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public List<SyncItem> SyncItemList { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            SyncItemList = new List<SyncItem>();
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                var t = new SyncItem
                {
                    Name = "Test",
                    LocalPath = "C:/test",
                    WebdavPath = "http://example.com/webdav"
                };

                SyncItemList.Add(t);
                return;
            }
        }
    }
}