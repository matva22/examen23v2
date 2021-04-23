using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace examen23v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        examenEntities db = new examenEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {

           
            Auth(login1.Text, password1.Password);
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            reg window = new reg();
            window.Show();
        }
        public bool Auth(string login, string password)
        {
           
           
            if (login.Length == 0 && password.Length == 0)
            {


                MessageBox.Show("Введите логин и пароль");
                return false;
            }
            else if (login.Length == 0)
            {

                MessageBox.Show("Введите логин ");
                return false;
            }
            else if (password.Length == 0)
            {


                MessageBox.Show("Введите пароль");
                return false;
            }
            else if (db.users.Where(u => u.login == login1.Text && u.password == password1.Password).FirstOrDefault() != null)
            {
                vhod window = new vhod();
                window.Show();
                this.Close();
                return true;

            }
            else if (db.users.Where(u => u.login != login1.Text && u.password != password1.Password).FirstOrDefault() != null)
            {
                MessageBox.Show("Неверно введён логин или пароль");
                return false;

            }
            return true;
        }

       

        private void Reg_Click1(object sender, RoutedEventArgs e)
        {
            reg window = new reg();
            window.Show();
            this.Close();
        }
    

    }
}
