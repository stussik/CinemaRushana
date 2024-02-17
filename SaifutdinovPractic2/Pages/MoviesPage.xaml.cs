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
    /// Логика взаимодействия для MoviesPage.xaml
    /// </summary>
    public partial class MoviesPage : Page
    {
        Movies contextMovies;
        public MoviesPage(Movies movies)
        {
            contextMovies = movies;
            DataContext = contextMovies;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextMovies.Id == 0)
                App.DB.Movies.Add(contextMovies);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
