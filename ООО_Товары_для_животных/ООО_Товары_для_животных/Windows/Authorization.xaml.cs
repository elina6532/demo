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
using ООО_Товары_для_животных.Models;

namespace ООО_Товары_для_животных.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            Assets.Classes.Navigation.auth = this;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length != 0 && Password.Text.Length != 0)
            {
                Users user = App.context.Users.ToList().Find(u => u.UserLogin == Login.Text && u.UserPassword == Password.Text);
                Roles roles = App.context.Roles.ToList().Find(r => r.RoleId == 1);
                if (user != null)
                {
                    Product win = new Product();
                    win.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Вы ввели неверные данные");
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void GuestEnter_Click(object sender, RoutedEventArgs e)
        {
            Product win = new Product();
            win.Show();
            this.Hide();
        }
    }
}
