﻿using ConnectionLibrary;
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

namespace Dashboard1.Inserts
{
    /// <summary>
    /// Interaction logic for Course_Insert.xaml
    /// </summary>
    public partial class Course_Insert : Window
    {
        public Course_Insert()
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

        private void Button_Click_InsertDB(object sender, RoutedEventArgs e)
        {
            Connection conn = new Connection();
            try
            {
                if (conn.Course_Insert_DB(txtName.Text, txtBirthday.Text) == 1)
                {
                    MessageBox.Show("OK");
                    txtName.Text = "";
                    txtBirthday.Text = "0000-00-00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry there is a problem");
            }


        }

    }
}