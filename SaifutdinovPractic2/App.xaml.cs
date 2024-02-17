using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SaifutdinovPractic2.Models;

namespace SaifutdinovPractic2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SaifutdinovPractic2KinoEntities DB = new SaifutdinovPractic2KinoEntities();
    }
}
