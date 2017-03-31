using System;
using System.Windows;
using ScandicFlagShop.Models;


namespace ScandicFlagShop
{
    /// <summary>
    /// Interaction logic for ScandicWindow.xaml
    /// </summary>
    public partial class ScandicWindow : Window
    {
        public ScandicWindow()
        {
            InitializeComponent();

            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }

        public FlagModel Flag { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {

            Flag = new FlagModel();
            Flag.ItemNum = int.Parse(uxItem.Text);
            Flag.Description = uxDescription.Text;
            Flag.PricePerItem = double.Parse(uxPrice.Text);
            Flag.Quantity = int.Parse(uxQuantity.Text);
            Flag.OurCost = double.Parse(uxOurCost.Text);
            Flag.Value = double.Parse(uxValue.Text);
            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

