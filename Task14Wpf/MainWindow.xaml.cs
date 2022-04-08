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

namespace Task14Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                ProductPrice = 6499,
                ProductImage= "Data/Микроволновая печь.jpg",
                ProductCategory = ProductCategories.Appliences
            });
            products.Add(new Product()
            {
                ProductName = "Макароны",
                ProductPrice = 120,
                ProductImage = "Data/Макароны.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                ProductPrice = 25600,
                ProductImage = "Data/Стиральная машина.jpg",
                ProductCategory = ProductCategories.Appliences
            });
            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductPrice = 350,
                ProductImage = "Data/Сыр.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Электрический духовой шкаф",
                ProductPrice = 31200,
                ProductImage = "Data/Электрический духовой шкаф.jpg",
                ProductCategory = ProductCategories.Appliences
            });
            products.Add(new Product()
            {
                ProductName = "Печенье",
                ProductPrice = 110,
                ProductImage = "Data/Милка.jpg",
                ProductCategory = ProductCategories.Food
            });
           
           
            lstBox.ItemsSource = products;



        }
    }


}
