using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;


namespace MiniProjTeam2_1
{
    class CaseStudy4
    {
    
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        
        public static SqlConnection getConnection()
        {
            con = new SqlConnection(@"Data Source=.;Initial Catalog=MiniProject;Integrated Security=True");

            con.Open();
            return con;
        }
        //public void register(Student student)
        //{
        public static void StudentRegistration(Student student)
        {

            con = getConnection();


            //giving static hard coded values as below will result in errors on successive execution
            // cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);
            Console.WriteLine("**************Student Registration**************");
            Console.WriteLine("Please enter StudentId");
            student.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Student Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please enter Student DOB");
            student.dob = Convert.ToDateTime(Console.ReadLine());


            cmd = new SqlCommand("insert into Student values(@ID,@Name,@dob)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@ID", student.ID);
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@dob", student.dob.ToShortDateString());





            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted successfully..");
            }
            else
                Console.WriteLine("Something went wrong..");
        }
        public static void CourseRegistration(Course course)
        {
            con = getConnection();


            //giving static hard coded values as below will result in errors on successive execution
            // cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);

            Console.WriteLine("Please enter CourseId");
            course.cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Course Name");
            course.name = Console.ReadLine();
            Console.WriteLine("Please enter Duration");
            course.duration = Console.ReadLine();
            Console.WriteLine("enter course fees");
            course.fee = Convert.ToSingle(Console.ReadLine());


            cmd = new SqlCommand("insert into Course values(@cid,@name,@duration,@fee)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@cid", course.cid);
            cmd.Parameters.AddWithValue("@name", course.name);
            cmd.Parameters.AddWithValue("@duration", course.duration);
            cmd.Parameters.AddWithValue("@fee", course.fee);





            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted Course data successfully..\n");
            }
            else
                Console.WriteLine("Something went wrong..");
        }

        public static void displayStudent()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("The student data list are:");
                cmd = new SqlCommand("select * from Student");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);

                    }
                }
                else
                {
                    Console.WriteLine("there is no data to display");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Error in the Server...");
            }
        }

        public static void displayCourse()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("The Course data list are:");
                cmd = new SqlCommand("select * from Course");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);

                    }
                }
                else
                {
                    Console.WriteLine("there is no data to display");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Error in the Server...");
            }
        }

        public static void DeleteStudent(Student student)
        {
            Console.WriteLine("***************Deleting student Data***********");
            Console.WriteLine();
            Console.WriteLine("Select the the id for the data which to be deleted from below list");
            displayStudent();
            con = getConnection();
            Console.WriteLine("Enter the student code to delete:");
            student.ID = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from student where ID=@sid", con);
            cmd1.Parameters.AddWithValue("@sid", student.ID);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            Console.WriteLine();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }

            if (dr1.HasRows)
            {
                con.Close();
                Console.WriteLine("\nAre you Sure to delete this Student? Y/N :");
                string status = Console.ReadLine();
                if (status == "y" || status == "Y")
                {
                    cmd = new SqlCommand("delete from Student where ID=@sid", con);
                    cmd.Parameters.AddWithValue("@sid", student.ID);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully...");
                    }
                    else
                        Console.WriteLine("Contact DBA..");
                }
                else
                {
                    Console.WriteLine("You Opted not to delete the Employee");
                }
            }
            else
            {
                Console.WriteLine("there is no data on the record");
            }
        }

        public static void UpdateStudent(Student student)
        {

            con = getConnection();
            SqlCommand cmd2;
            Console.WriteLine("Enter the student id to Update the name");
            student.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name to be updated");
            student.Name = Console.ReadLine();
            cmd2 = new SqlCommand("UPDATE student Set Name=@Sname where ID=@sid ", con);
            cmd2.Parameters.AddWithValue("@sid", student.ID);
            cmd2.Parameters.AddWithValue("@Sname", student.Name);
            try
            {
                int data = cmd2.ExecuteNonQuery();

                if (data > 0)
                {
                    Console.WriteLine("Updated successfully");
                }
                else
                {
                    Console.WriteLine("Update failed");
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
       
    }
}
