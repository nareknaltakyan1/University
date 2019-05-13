using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary
{
    public class Connection
    {
        public SqlConnection connection;

        private string server;
        private string database;
        private string Userid;
        private string password;


        public static string UserName1;


        public Connection()
        {
            server = "SQL5041.site4now.net";
            database = "DB_A4753D_university";
            Userid = "DB_A4753D_university_admin";
            password = "94954838Ln#";

            string connectionString;
            connectionString = (@"SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + Userid + ";" + "PASSWORD=" + password + ";");

            connection = new SqlConnection(connectionString);

            //connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = Smartphone; Integrated Security = True;");
        }


        public int OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return 0;
        }


        private void CloseConnection()
        {
            connection.Close();
        }



        public int Login(string a, string b)
        {
            if (OpenConnection() != 0)
                return 1;

            String query = "SELECT COUNT(1) FROM users WHERE Username=@UserName AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            //LogIn dashboardl = new LogIn();

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = a;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = b;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }


        public int Registration(string UserName, string Password)
        {
            if (this.OpenConnection() == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO users(UserName, Password, Faculty, Age, Salary) VALUES(@UserName, @Password, @Faculty, @Age, @Salary);";
                cmd.Connection = connection;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                cmd.Parameters.Add("@Faculty", SqlDbType.VarChar).Value = "-";
                cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = "-";
                cmd.Parameters.Add("@Salary", SqlDbType.VarChar).Value = "-";



                cmd.ExecuteNonQuery();
                return 0;

            }
            else
            {
                return 1;
            }
        }





        public void ChangeProfile(string UserName, string Facullty, int Age, int Salary)
        {
            if (this.OpenConnection() == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE users SET Faculty=@Faculty, Age=@Age, Salary=@Salary WHERE UserName=@UserName; ";
                cmd.Connection = connection;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@Faculty", SqlDbType.VarChar).Value = Facullty;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                cmd.Parameters.Add("@Salary", SqlDbType.Int).Value = Salary;



                cmd.ExecuteNonQuery();
            }
        }




        public object SearchLogin(string a, int i)
        {
            object Text;

            if (OpenConnection() != 0)
            {
                Text = "None";
                return Text;
            }

            String query = "SELECT Faculty, Age, Salary FROM users WHERE Username=@UserName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            //LogIn dashboardl = new LogIn();

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = a;



            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (i == 0)
                    Text = reader.GetString(0);
                else if (i == 1)
                    Text = reader.GetInt32(1);
                else
                    Text = reader.GetInt32(2);

            }
            else
            {
                Text = "None";
            }
            reader.Close();
            return Text;
        }



        public bool Delete(int a)
        {


            if (OpenConnection() != 0)
            {

                return false;
            }

            String query = "Delete FROM students WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            //LogIn dashboardl = new LogIn();

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = a;

            cmd.ExecuteNonQuery();
            return true;


        }


        //------------------------------------------------------------------------------------UPDATES-----------------------------------------------------------------------------------

        public int Subject_Update_DB(int ID, string Name)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update subjects SET Name=@Name WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;

            cmd.ExecuteNonQuery();
            return 0;
        }

        public int Course_Update_DB(int ID, string Name, string Birthday)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update course SET Name=@Name, Birthday=@Birthday WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;

            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Student_Subject_Update_DB(int ID, int Student_Id, int Subject_Id, int Mark)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update Student_Subject SET Student_ID=@Student_ID, Subjects_ID=@Subjects_ID, Mark=@Mark WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@Student_ID", SqlDbType.Int).Value = Student_Id;
            cmd.Parameters.Add("@Subjects_ID", SqlDbType.Int).Value = Subject_Id;
            cmd.Parameters.Add("@Mark", SqlDbType.Int).Value = Mark;

            cmd.ExecuteNonQuery();
            return 0;
        }

        public int Teacher_Subject_Update_DB(int ID, int Teacher_ID, int Subject_Id)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update Teacher_Subject SET Teacher_ID=@Teacher_ID, Subject_ID=@Subject_ID WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@Teacher_ID", SqlDbType.Int).Value = Teacher_ID;
            cmd.Parameters.Add("@Subject_ID", SqlDbType.Int).Value = Subject_Id;

            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Student_Update_DB(int ID, string FirstName, string LastName, string MiddleName, string Birthday, string Address, string Phone)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update students SET FirstName=@FirstName, LastName=@LastName, MiddleName=@MiddleName, Birthday=@Birthday, Address=@Address, Phone=@Phone WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;

            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Teacher_Update_DB(int ID, string FirstName, string LastName, string MiddleName, string Birthday, string Address, string Phone)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Update teachers SET FirstName=@FirstName, LastName=@LastName, MiddleName=@MiddleName, Birthday=@Birthday, Address=@Address, Phone=@Phone WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;

            cmd.ExecuteNonQuery();
            return 0;
        }


        //------------------------------------------------------------------------------------DELETE--------------------------------------------------------------------------------------------------

        public int Course_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from student_subject WHERE student_id=any(select Id from students where Course_Id=@Id);  Delete from students WHERE Course_Id=@id; Delete from course WHERE id=@id;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Student_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from student_subject WHERE student_id=@id;  Delete from students WHERE Id=@id;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Student_Subject_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from student_subject WHERE student_id=@id;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }


        public int Subject_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from subjects WHERE id=@id;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }

        public int Teacher_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from teacher_subject WHERE teacher_id=@id; Delete from teachers where id=@id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }

        public int Teacher_Subject_Delete_DB(int ID)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Delete from teacher_subject WHERE teacher_id=@id;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;


            cmd.ExecuteNonQuery();
            return 0;
        }


        //----------------------------------------------------------------------------------------------------------------INSERT--------------------------------------------------------------------------------------------------------

        public int Student_Insert_DB(string FirstName, string LastName, string MiddleName, string Birthday, string Address, string Phone, int Course_Id)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO students values(@FirstName, @LastName, @MiddleName, @Birthday, @Address, @Phone, @Course_Id);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            cmd.Parameters.Add("@Course_Id", SqlDbType.Int).Value = Course_Id;


            return cmd.ExecuteNonQuery();
        }

        public int Teacher_Insert_DB(string FirstName, string LastName, string MiddleName, string Birthday, string Address, string Phone)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO teachers values(@FirstName, @LastName, @MiddleName, @Birthday, @Address, @Phone);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;

            return cmd.ExecuteNonQuery();
        }


        public int Course_Insert_DB(string Name, string Birthday)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO course values(@Name, @Birthday);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = Birthday;

            return cmd.ExecuteNonQuery();
        }


        public int Student_Subject_Insert_DB(int Student_Id, int Subject_Id, int Mark)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO student_subject values(@Student_Id, @Subject_Id, @Mark);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Student_Id", SqlDbType.Int).Value = Student_Id;
            cmd.Parameters.Add("@Subject_Id", SqlDbType.Int).Value = Subject_Id;
            cmd.Parameters.Add("@Mark", SqlDbType.Int).Value = Mark;

            return cmd.ExecuteNonQuery();
        }




        public int Subject_Insert_DB(string Name)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO subjects values(@Name);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;

            return cmd.ExecuteNonQuery();
        }


        public int Teacher_Subject_Insert_DB(int Teacher_ID, int Subject_Id)
        {
            if (OpenConnection() != 0)
            {

                return -1;
            }

            String query = "Insert INTO teacher_subject values(@Teacher_Id, @Subject_Idk);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Teacher_ID", SqlDbType.Int).Value = Teacher_ID;
            cmd.Parameters.Add("@Subject_Id", SqlDbType.Int).Value = Subject_Id;

            return cmd.ExecuteNonQuery();
        }



        //------------------------------------------------------------------------------------------------GRID----------------------------------------------------------------------------------------------

        public DataTable Course_Grid_DB(int Count)
        {

            String query = "Select * from course where id>@A1 and id<=@A2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Students");
            da.Fill(dt);

            return dt;

        }

        public DataTable Student_Subject_Grid_DB(int Count)
        {

            String query = "Select * from student_subject where id>@A1 and id<=@A2 ORDER BY student_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Student_Subject");
            da.Fill(dt);

            return dt;

        }


        public DataTable Student_Grid_DB(int Count)
        {
            String query = "Select * from students where id>@A1 and id<=@A2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Students");
            da.Fill(dt);

            return dt;


        }




        public DataTable Subject_Grid_DB(int Count)
        {
            String query = "Select * from subjects where id>@A1 and id<=@A2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Subjects");
            da.Fill(dt);

            return dt;

        }


        public DataTable Teache_Subject_Grid_DB(int Count)
        {
            String query = "Select * from teacher_subject where id>@A1 and id<=@A2 ORDER BY teacher_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Student_Subject");
            da.Fill(dt);


            return dt;

        }


        public DataTable Teache_Grid_DB(int Count)
        {
            String query = "Select * from teachers where id>@A1 and id<=@A2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@A2", SqlDbType.Int).Value = Count;
            cmd.Parameters.Add("@A1", SqlDbType.Int).Value = Count - 5;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("teachers");
            da.Fill(dt);

            return dt;

        }

        public string Select(int ID)
        {
            string query = "SELECT * FROM students where id = @ID";

            string[] list = new string[3];
            

            if (this.OpenConnection() == 0)
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0]=(dataReader[""] + "");
                    list[1]=(dataReader[""] + "");
                    list[2]=(dataReader[""] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list[0];
            }
            else
            {
                return list[0];
            }
        }



    }
}