using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace examen23v2
{
    /// <summary>
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Window
    {
        examenEntities db = new examenEntities();
        public vhod()
        {
            InitializeComponent();
            db.tavar.Load();
            db.Продажи.Load();
            table.ItemsSource = db.tavar.Local;
            table2.ItemsSource = db.Продажи.Local;
        }
    }
}
