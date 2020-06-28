using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFOLD.Controllers;

namespace WPFOLD.Views
{
    /// <summary>
    /// Interaction logic for Region.xaml
    /// </summary>
    public partial class Region : Window
    {
        RegionController regionController = new RegionController();

        public Region()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (regionController.Insert(NameText.Text))
            {
                MessageBox.Show("Data Has Been Submitted");
                RegionGrid.ItemsSource = regionController.Get();
            }
            else
            {
                MessageBox.Show("Data Failed to Submit");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegionGrid.ItemsSource = regionController.Get();
        }
    }
}
