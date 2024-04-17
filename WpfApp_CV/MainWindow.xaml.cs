using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace WpfApp_CV
{
    public partial class ResumeWindow : Window
    {
        public ResumeWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Clipboard.SetText(e.Uri.ToString());

            copyPopup.IsOpen = true;

            Task.Delay(1000).ContinueWith(_ =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    copyPopup.IsOpen = false;
                });
            });
        }
    }
}