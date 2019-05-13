using ConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Dashboard1.Grid
{
    /// <summary>
    /// Interaction logic for students_grid.xaml
    /// </summary>
    /// 

    
    public partial class students_grid : Window
    {
        private static int Count_Grid = 5;
       
        public students_grid()
        {
            InitializeComponent();
            binddatagrid();
        }
        
        private void ButtonFechar_Click1(object sender, RoutedEventArgs e)
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
            Update d = new Update();
            d.Show();
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

        private void Button_Click_LogOut(object sender, RoutedEventArgs e)
        {
            Login d = new Login();
            d.Show();
            this.Close();
        }
        //////////////////////////////////////////////////



        private void Button_Click_DeleteDB(object sender, RoutedEventArgs e)
        {
            Connection conn = new Connection();



        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void binddatagrid()
        {
            Connection conn = new Connection();
            try
            {
                DataGrid1.ItemsSource = conn.Student_Grid_DB(Count_Grid).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry there is a problem");
            }

        }
        

        private void Button_Click_NextGrid(object sender, RoutedEventArgs e)
        {
            Count_Grid += 5;
            students_grid d = new students_grid();
            d.Show();
            this.Close();
        }

        private void Button_Click_PreviousGrid(object sender, RoutedEventArgs e)
        {
            Count_Grid -= 5;
            if(Count_Grid==0)
                Count_Grid=5;
            students_grid d = new students_grid();
            d.Show();
            this.Close();
        }
    }
}
