using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ScandicFlagShop.Models;

namespace ScandicFlagShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            LoadScandicFlags();
        }

        private void LoadScandicFlags()
        {
            var flags = App.FlagRepository.GetAll();

            uxList.ItemsSource = flags
                .Select(t => FlagModel.ToModel(t))
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ScandicWindow();

            if (window.ShowDialog() == true)
            {
                var uiFlagModel = window.Flag;

                var repositoryFlagModel = uiFlagModel.ToRepositoryModel();

                App.FlagRepository.Add(repositoryFlagModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadScandicFlags();
            }
        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            var window = new ScandicWindow();
            window.Flag = selectedContact.Clone();

            if (window.ShowDialog() == true)
            {
                App.FlagRepository.Update(window.Flag.ToRepositoryModel());
                LoadScandicFlags();
            }
        }

        

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.FlagRepository.Remove(selectedContact.ItemNum);
            selectedContact = null;
            LoadScandicFlags();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedContact != null);
        }

        private FlagModel selectedContact;

        private void uxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedContact = (FlagModel)uxList.SelectedValue;
        }

        private void uxList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            uxFileChange_Click(sender, null);
        }

    }
}
