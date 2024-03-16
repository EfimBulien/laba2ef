using System;
using System.Linq;
using System.Windows;

namespace laba2ef
{
    public partial class DriversEditorWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public DriversEditorWindow()
        {
            InitializeComponent();
            DriversDataGrid.ItemsSource = lab1Entities.drivers.ToList();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            drivers driver = new drivers();
            driver.firstname = firstnameBox.Text;
            driver.surname = surnameBox.Text;
            driver.middlename = middlenameBox.Text;
            driver.car_id = Convert.ToInt32(car_idBox.Text);
            lab1Entities.drivers.Add(driver);
            SaveChanges();
            ResetTextBoxes();

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversDataGrid.SelectedItem != null)
            {
                var selected = DriversDataGrid.SelectedItem as drivers;
                selected.firstname = firstnameBox.Text;
                selected.surname = surnameBox.Text;
                selected.middlename = middlenameBox.Text;
                selected.car_id = Convert.ToInt32(car_idBox.Text);
                SaveChanges();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversDataGrid.SelectedItem != null)
            {
                lab1Entities.drivers.Remove(DriversDataGrid.SelectedItem as drivers);
                SaveChanges();
                ResetTextBoxes();
            }
        }

        private void SaveChanges()
        {
            lab1Entities.SaveChanges();
            DriversDataGrid.ItemsSource = lab1Entities.drivers.ToList();
        }

        private void ResetTextBoxes()
        {
            firstnameBox.Text = null;
            surnameBox.Text = null;
            middlenameBox.Text = null;
            car_idBox.Text = null;
        }
    }
}
