using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace WebdavSync.App.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using Microsoft.Practices.ServiceLocation;
    using WebdavSync.Model;

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
        public List<SyncFolder> SyncFolderList { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            SyncFolderList = new List<SyncFolder>();
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                var t = new SyncFolder
                {
                    Name = "Test",
                    LocalPath = "C:/test",
                    WebdavPath = "http://example.com/webdav"
                };

                SyncFolderList.Add(t);
                return;
            }

            NewDialogVm = new NewDialogViewModel();
        }

        private ObservableCollection<Webdav> webdavList;

        public ObservableCollection<Webdav> WebdavList
        {
            get => this.webdavList;
            set
            {
                this.webdavList = value;
                this.RaisePropertyChanged();
            }
        }

        private NewDialogViewModel newDialogVm;

        public NewDialogViewModel NewDialogVm
        {
            get => this.newDialogVm;
            set
            {
                this.newDialogVm = value;
                this.RaisePropertyChanged();
            }
        }
    }
}