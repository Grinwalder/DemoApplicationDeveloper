using System.Windows;

namespace WPFDeveloper.View
{
    /// <summary>
    /// Logique d'interaction pour DeveloppersView.xaml
    /// </summary>
    public partial class DevelopersView : Window
    {
        public DevelopersView()
        {
            InitializeComponent();            
        }

        private void BT_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
