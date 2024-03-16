using System.Linq;
using System.Windows;

namespace laba2ef
{
    public partial class CarsEditorWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public CarsEditorWindow()
        {
            InitializeComponent();
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            cars car = new cars();
            car.model = modelBox.Text;
            car.number = numberBox.Text;
            car.color = colorBox.Text;
            lab1Entities.cars.Add(car);
            SaveChanges();
            ResetTextBoxes();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (CarsDataGrid != null)
            {
                var selected = CarsDataGrid.SelectedItem as cars;
                selected.model = modelBox.Text;
                selected.number = numberBox.Text;
                selected.color = colorBox.Text;
                SaveChanges();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(CarsDataGrid != null)
            {
                lab1Entities.cars.Remove(CarsDataGrid.SelectedItem as cars);
                SaveChanges();
                ResetTextBoxes();
            }
        }

        private void SaveChanges()
        {
            lab1Entities.SaveChanges();
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList();
        }

        private void ResetTextBoxes()
        {
            modelBox.Text = string.Empty;
            numberBox.Text = string.Empty;
            colorBox.Text = string.Empty;
        }
    }
}
