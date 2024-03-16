using System.Windows;

namespace laba2ef
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCarsEditorWindow_Click(object sender, RoutedEventArgs e)
        {
            CarsEditorWindow carsEditorWindow = new CarsEditorWindow();
            carsEditorWindow.ShowDialog();
        }

        private void OpenDriversEditorWindow_Click(object sender, RoutedEventArgs e)
        {
            DriversEditorWindow driversEditorWindow = new DriversEditorWindow();
            driversEditorWindow.ShowDialog();
        }
    }
}
