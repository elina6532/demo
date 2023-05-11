using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ООО_Товары_для_животных.Windows
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
            Assets.Classes.Navigation.prod = this;
            LoadData();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }

        private void Filtration_DropDownClosed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Asc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Desc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            ProductView.Children.Clear();
            List<Models.Products> list = App.context.Products.ToList();
            if (Filtration.SelectedItem!=null)
            {
                switch (Filtration.SelectedIndex)
                {
                    case 0:
                        list = App.context.Products.ToList();
                        break;
                    case 1:
                        list = list.Where(p => p.ProductDiscountAmount > 5 && p.ProductDiscountAmount < 7).ToList();
                        break;
                    case 2:
                        list = list.Where(p => p.ProductDiscountAmount > 7 && p.ProductDiscountAmount < 15).ToList();
                        break;
                    case 3:
                        list = list.Where(p => p.ProductDiscountAmount > 15 && p.ProductDiscountAmount < 100).ToList();
                        break;
                }
            }
            if (Search.Text.Length != 0)
                list = list.Where(p => p.ProductName.Contains(Search.Text)).ToList();
            if (Asc.IsChecked == true)
                list = list.OrderBy(p => p.ProductCost).ToList();
            else if (Desc.IsChecked == true)
                list = list.OrderByDescending(p => p.ProductCost).ToList();
            foreach (var item in list)
                ProductView.Children.Add(new Assets.UserControls.ProductCard(item.ProductArticleNumber, item.ProductDescription, item.ProductName, item.ProductManufacturer.ToString(), item.ProductCost.ToString(), item.ProductDiscountAmount.ToString(), Convert.ToDecimal(item.ProductDiscountAmount), item.ProductPhoto));

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Authorization win = new Authorization();
            win.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
