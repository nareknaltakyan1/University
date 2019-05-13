using ConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();            
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Button_Click_Submit(object sender, RoutedEventArgs e)
        {
            Connection conn = new Connection();

            Connection.UserName1 = txtUsername.Text;


            if (conn.connection.State == ConnectionState.Closed)
                conn.connection.Open();

            try
            {
                if (conn.Login(txtUsername.Text, txtPassword.Password) == 0)
                {
                    MainWindow d = new MainWindow();
                    d.Show();
                    this.Close();
                }
                else if (conn.Login(txtUsername.Text, txtPassword.Password) == -1)
                {
                    MessageBox.Show("username or password is incorrect");
                }
                else
                {
                    MessageBox.Show("Server Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry there is a problem");
            }

            
        }

        private void Button_Click_Registration(object sender, RoutedEventArgs e)
        {
            Registration d = new Registration();
            d.Show();
            this.Close();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

    
}

