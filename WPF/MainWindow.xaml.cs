using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Container_Loaded(object sender, RoutedEventArgs e)
        {
            MainView.Height = Container.ActualHeight - ExcludedZone.ActualHeight - 24;
        }

        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainView.Height = Container.ActualHeight - ExcludedZone.ActualHeight - 24;
        }
    }
}