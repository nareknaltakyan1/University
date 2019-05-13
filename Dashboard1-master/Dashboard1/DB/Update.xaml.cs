using Dashboard1;
using Dashboard1.Updates;
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
    public partial class Update : Window
    {
        public Update()
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

        private void Button_Click_UpdateDB(object sender, RoutedEventArgs e)
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

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Button_Click_StudentUpdate(object sender, RoutedEventArgs e)
        {
            student_update d = new student_update();
            d.Show();
            this.Close();
        }

        private void Button_Click_TeacherUpdate(object sender, RoutedEventArgs e)
        {
            teacher_update d = new teacher_update();
            d.Show();
            this.Close();
        }

        private void Button_Click_CourseUpdate(object sender, RoutedEventArgs e)
        {
            course_update d = new course_update();
            d.Show();
            this.Close();
        }

        private void Button_Click_SubjectUpdate(object sender, RoutedEventArgs e)
        {
            subject_update d = new subject_update();
            d.Show();
            this.Close();
        }

        private void Button_Click_Student_SubjectUpdate(object sender, RoutedEventArgs e)
        {
            student_subject_update d = new student_subject_update();
            d.Show();
            this.Close();
        }

        private void Button_Click_Teacher_SubjectUpdate(object sender, RoutedEventArgs e)
        {
            teacher_subject_update d = new teacher_subject_update();
            d.Show();
            this.Close();
        }
    }
}
