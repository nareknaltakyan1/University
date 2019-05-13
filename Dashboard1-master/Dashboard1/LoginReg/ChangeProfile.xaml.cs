using ConnectionLibrary;
using Dashboard1;
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
using System.Windows.Shapes;

namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class ChangeProfile : Window
    {
        public ChangeProfile()
        {
            InitializeComponent();

            txtUsername.Text = Connection.UserName1;

            Connection conn = new Connection();

            conn.SearchLogin(Connection.UserName1, 0);


            this.txtFaculty.Text += Convert.ToString(conn.SearchLogin(Connection.UserName1, 0));
            this.txtAge.Text += Convert.ToString(conn.SearchLogin(Connection.UserName1, 1));
            this.txtSalary.Text += Convert.ToString(conn.SearchLogin(Connection.UserName1, 2));
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// /////////////////////////////////////////////////////////////

        private void Button_Click_DASHBOARD(object sender, RoutedEventArgs e)
        {
            MainWindow d = new MainWindow();
            d.Show();
            this.Close();
        }

        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            Profile d = new Profile();
            d.Show();
            this.Close();
        }

        private void Button_Click_Insert(object sender, RoutedEventArgs e)
        {
            Insert d = new Insert();
            d.Show();
            this.Close();

        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            //Update d = new Update();
            //d.Show();
            this.Close();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Close();
        }

        private void Button_Click_Configuration(object sender, RoutedEventArgs e)
        {
            ChangeProfile d = new ChangeProfile();
            d.Show();
            this.Close();
        }
        private void Button_Click_Select(object sender, RoutedEventArgs e)
        {
            Select d = new Select();
            d.Show();
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Button_Click_ChangeProfileDB(object sender, RoutedEventArgs e)
        {
            Connection conn = new Connection();
            bool t = true;
            if (txtAge.Text.Length == 1 && !(txtAge.Text[0] >= '0' && txtAge.Text[0] <= '9'))
            {            
                MessageBox.Show("Incorect Age!!");
                t = false;
            }
            else
            {
                for (int i = 1; i < txtAge.Text.Length; i++)
                {
                    if (!(txtAge.Text[i] >= '0' && txtAge.Text[i] <= '9'))
                    {
                        MessageBox.Show("Incorect Age!!");
                        t = false;
                        break;
                    }
                }
            }

            if (txtAge.Text.Length == 1 && !(txtAge.Text[0] >= '0' && txtAge.Text[0] <= '9'))
            {
                MessageBox.Show("Incorect Age!!");
                t = false;
            }
            else
            {
                for (int i = 1; i < txtSalary.Text.Length; i++)
                {
                    if (!(txtSalary.Text[i] >= '0' && txtSalary.Text[i] <= '9'))
                    {
                        MessageBox.Show("Incorect Salary!!");
                        t = false;
                        break;
                    }
                }
            }

            try
            {
                if (t==true)
                    conn.ChangeProfile(txtUsername.Text, txtFaculty.Text, Int32.Parse(txtAge.Text), Int32.Parse(txtSalary.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry there is a problem");
            }
            

        }

        private void TxtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtUsername.Text = Connection.UserName1;
        }

        private void Button_Click_LogOut(object sender, RoutedEventArgs e)
        {
            Login d = new Login();
            d.Show();
            this.Close();
        }


        //////////////////////////////////////////////////
    }
}
