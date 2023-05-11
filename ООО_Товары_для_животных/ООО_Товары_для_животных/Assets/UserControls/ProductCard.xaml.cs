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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ООО_Товары_для_животных.Models;
using System.IO;

namespace ООО_Товары_для_животных.Assets.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        string Article;
        public ProductCard(string Article,string Description,string Title,string Manufacturer,string Cost,string DiscountAmount,decimal Sale,byte[] img)
        {
            InitializeComponent();
            this.Article = Article;
            this.Description.Text = Description;
            this.Title.Text = Title;
            Manufacturer manufacturer = App.context.Manufacturer.ToList().Find(m => m.ManufacturerId.ToString() == Manufacturer);
            this.Manufacturer.Text += manufacturer.ProductManufacturer;
            this.Costt.Text += Cost.Split(',')[0] + " p";
            this.DiscountAmount.Text = DiscountAmount;
            if (Sale > 15)
                BackgroundSale.Background = SaleColor.Background;
            if (Sale > 0)
                CostDiscount.Visibility = Visibility.Visible;
            Costt.TextDecorations = Strike.TextDecorations;
            CostDiscount.Text += (Convert.ToDecimal(Cost) - Convert.ToDecimal(Cost) * Sale / 100).ToString().Split(',')[0] + " p";

            try
            {
                BitmapImage image = new BitmapImage();
                MemoryStream Ms = new MemoryStream(img);
                image.BeginInit();
                image.StreamSource = Ms;
                image.EndInit();
                this.Images.Source = image;
            }
            catch
            { }

        }
    }
}
