using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace WebdavSync.App.ViewModel
{
    using System.Data.Odbc;
    using GalaSoft.MvvmLight.CommandWpf;
    using Microsoft.Win32;
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
    public class NewDialogViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public NewDialogViewModel()
        {
        }

        private SyncFolder syncFolder;

        public SyncFolder SyncFolder
        {
            get => this.syncFolder;
            set
            {
                this.syncFolder = value;
                this.RaisePropertyChanged();
            }
        }

        public RelayCommand Browse => new RelayCommand(this.BrowseExecute);

        private void BrowseExecute()
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();

        }
    }
}