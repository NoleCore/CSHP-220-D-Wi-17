using System.Windows;

namespace ScandicFlagShop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static FlagRepository.FlagRepository flagRepository;

        static App()
        {
            flagRepository = new FlagRepository.FlagRepository();
        }

        public static FlagRepository.FlagRepository FlagRepository
        {
            get
            {
                return flagRepository;
            }
        }

    }
}
