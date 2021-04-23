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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        examenEntities db = new examenEntities();
        public reg()
        {
            InitializeComponent();
            db.users.Load();
        }

        private void Reg1_Click(object sender, RoutedEventArgs e)
        {
            string logingg = logintt.Text.Trim();
            string passwordgg = password1.Password.Trim();


            if (logingg.Length == 0 && passwordgg.Length == 0)
            {


                MessageBox.Show("Введите логин и проль");


            }
            else if (logingg.Length == 0)
            {

                MessageBox.Show("Введите логин");

            }
            else if (passwordgg.Length == 0)
            {


                MessageBox.Show("Введите пароль");

            }


            else if (db.users.Where(u => u.login == logintt.Text).FirstOrDefault() != null)
            {



                MessageBox.Show("Такой логин уже существует");




            }
            else if (db.users.Where(u => u.login != logintt.Text).FirstOrDefault() != null)
            {

                users p = new users();
                p.login = logintt.Text;
                p.password = password1.Password;
                db.users.Add(p);
                db.SaveChanges();
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();



            }



        
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();  
        }
    }
}
