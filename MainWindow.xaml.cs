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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.IO;

namespace Task_WPF14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Телевизор",
                price = 32000,
                image = Directory.GetCurrentDirectory() + "\\ProductData\\TV.jpg",
                category = "Бытовая техника"
            });
            products.Add(new Product()
            {
                Name = "Холодильник",
                price = 64025,
                image = Directory.GetCurrentDirectory() + "\\ProductData\\Холодильник.jpg",
                category = "Бытовая техника"
            });
            products.Add(new Product()
            {
                Name = "Яблоки",
                price = 160,
                image = Directory.GetCurrentDirectory() + "\\ProductData\\Apple.jpg",
                category = "Еда"
            });
            products.Add(new Product()
            {
                Name = "Апельсины",
                price = 160,
                image = Directory.GetCurrentDirectory() + "\\ProductData\\Апельсины.jpg",
                category = "Еда"
            });
            lstBox.ItemsSource = products;

        }
    }
}
