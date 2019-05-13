using Dashboard1;
using Dashboard1.Inserts;
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
    /// Interaction logic for Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        public Insert()
        {
            InitializeComponent();
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

        private void Button_Click_StudentINSERT(object sender, RoutedEventArgs e)
        {
            Student_Insert d = new Student_Insert();
            d.Show();
            this.Close();
        }

        private void Button_Click_TeacherINSERT(object sender, RoutedEventArgs e)
        {
            Teacher_Insert d = new Teacher_Insert();
            d.Show();
            this.Close();
        }

        private void Button_Click_CourseINSERT(object sender, RoutedEventArgs e)
        {
            Course_Insert d = new Course_Insert();
            d.Show();
            this.Close();
        }

        private void Button_Click_SubjectINSERT(object sender, RoutedEventArgs e)
        {
            Subject_Insert d = new Subject_Insert();
            d.Show();
            this.Close();
        }

        private void Button_Click_Student_SubjectINSERT(object sender, RoutedEventArgs e)
        {
            Student_Subject_Insert d = new Student_Subject_Insert();
            d.Show();
            this.Close();
        }

        private void Button_Click_Teacher_SubjectINSERT(object sender, RoutedEventArgs e)
        {
            Teacher_Subject_Insert d = new Teacher_Subject_Insert();
            d.Show();
            this.Close();
        }
    }
}
