using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ООО_Товары_для_животных.Models;
namespace ООО_Товары_для_животных
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static trade203Context context { get; } = new trade203Context();
    }
}
