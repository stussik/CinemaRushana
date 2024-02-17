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
using SaifutdinovPractic2.Models;

namespace SaifutdinovPractic2.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuKinoPage.xaml
    /// </summary>
    public partial class MenuKinoPage : Page
    {
        
        public MenuKinoPage()
        {
            InitializeComponent();
            CBPuskinCard.ItemsSource = App.DB.PuskinCard.ToList();
            CBJanr.ItemsSource = App.DB.Janr.ToList();
        }

        private void ButtonAdd2_Click(object sender, RoutedEventArgs e)
        {
            Movies kino = new Movies();
            kino.Name = DBCinemaName.Text;
            kino.Description = DBCinemaDescription.Text;
            kino.DatePokaza = DateTime.Parse(DBCinemaAir.Text);
            kino.JanrId = int.Parse(CBJanr.Text);
            kino.PuskinCard = int.Parse(CBPuskinCard.Text);
            App.DB.Movies.Add(kino);
            App.DB.SaveChanges();
            MessageBox.Show("Кино добавлено!");
           
        }

        private void ButtonBack2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TBDobav_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Login = TBLogin.Text;
            user.Password = TBPassword.Text;
            App.DB.User.Add(user);
            App.DB.SaveChanges();
            MessageBox.Show("Пользователь добавлен!");
        }

        private void TBNazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
