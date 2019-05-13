using Dashboard1;
using Dashboard1.Grid;
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
    public partial class Select : Window
    {
        public Select()
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

        private void Button_Click_SelectDB(object sender, RoutedEventArgs e)
        {

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

        private void Button_Click_StudentGrid(object sender, RoutedEventArgs e)
        {
            students_grid d = new students_grid();
            d.Show();
            this.Close();
        }

        private void Button_Click_TeacherGrid(object sender, RoutedEventArgs e)
        {
            teachers_grid d = new teachers_grid();
            d.Show();
            this.Close();
        }

        private void Button_Click_CourseGrid(object sender, RoutedEventArgs e)
        {
            courses_grid d = new courses_grid();
            d.Show();
            this.Close();
        }

        private void Button_Click_SubjectGrid(object sender, RoutedEventArgs e)
        {
            subjects_grid d = new subjects_grid();
            d.Show();
            this.Close();

        }

        private void Button_Click_Student_SubjectGrid(object sender, RoutedEventArgs e)
        {
            student_subject_grid d = new student_subject_grid();
            d.Show();
            this.Close();
        }

        private void Button_Click_Teacher_SubjectGrid(object sender, RoutedEventArgs e)
        {
            teacher_subject_grid d = new teacher_subject_grid();
            d.Show();
            this.Close();
        }
        //////////////////////////////////////////////////
    }
}
