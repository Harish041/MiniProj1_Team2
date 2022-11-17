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
            try
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
            catch(FormatException fe)
            {
                Console.WriteLine("Error: invalid input..");
                StudentRegistration(student);
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error: Student is already register");
                StudentRegistration(student);
            }
        }
        public static void CourseRegistration(Course course)
        {
            try
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
            catch (SqlException pkViolation)
            {
                Console.WriteLine("Error :This Course is already there");
                CourseRegistration(course);
            }
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
                displayStudent();
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
                        Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]+" "+dr[3]);

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
                displayCourse();
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

                Console.WriteLine("Error :"+ex.Message);
                UpdateStudent(student);

            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateCourse(Course course)
        {

            con = getConnection();
            SqlCommand cmd2;
            Console.WriteLine("******update Course**********");
            Console.WriteLine("Course id and duration of the course is disable for updation");
            Console.WriteLine("Please enter CourseId to update");
            course.cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Course Name to update");
            course.name = Console.ReadLine();
            Console.WriteLine("enter course fees");
            course.fee = Convert.ToSingle(Console.ReadLine());
            cmd2 = new SqlCommand("UPDATE student Set course.cid = @cid,course.name = @name,course.fee = @fee where course.cid = @cid ", con);
            cmd2.Parameters.AddWithValue("@cid", course.cid);
            cmd2.Parameters.AddWithValue("@name", course.name);
            cmd2.Parameters.AddWithValue("@fee", course.fee);
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

                Console.WriteLine("Error :" + ex.Message);
                UpdateCourse(course);
            }
            finally
            {
                con.Close();
            }
        }



        public static void Enroll(Student student, Course course)
        {
            try
            {
                Console.WriteLine("select which student do you want to register in the below list ");
                CaseStudy4.displayStudent();
                Console.WriteLine("These are the course available select any one ");
                CaseStudy4.displayCourse();
                con = getConnection();
                SqlCommand cmd2;
                Console.WriteLine("Enter the student id");
                student.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name");
                Console.WriteLine("Enter the course id");
                course.cid = Convert.ToInt32(Console.ReadLine());
                Enroll e = new Enroll();
                e.enrollDate = Convert.ToDateTime(DateTime.Now);
                cmd2 = new SqlCommand("Insert into Enroll values(@StudentID,@Cid,@Enrollment) ", con);
                cmd2.Parameters.AddWithValue("@StudentID", student.ID);
                cmd2.Parameters.AddWithValue("@Cid", course.cid);
                cmd2.Parameters.AddWithValue("@Enrollment", e.enrollDate.ToShortDateString());
                int data = cmd2.ExecuteNonQuery();
                if (data > 0)
                {
                    Console.WriteLine("inserted sucessfully");
                }
                else
                {
                    Console.WriteLine("insertion failed....");
                }
                Enroll(student, course);
                con.Close();
            }catch(FormatException fe)
            {
                Console.WriteLine("invalid input");
                Enroll(student,course);
            }
            catch(SqlException se)
            {
                Console.WriteLine("Student already Enrolled....!");
                Enroll(student,course);
            }
        }

        public static void displayEnrollments()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("*************Enrolled student data*************");
                cmd = new SqlCommand("select e.EnrollmentID,e.Enrollment,s.*,c.* from Enroll e join Student s on e.StudentID = s.ID  join Course c on c.cid = e.CourseID");            
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    
                    while(dr.Read())
                    {
                
                        Console.WriteLine(" EnrollmentID: {0}\n EnrollmentDate: {1}\n StudentId: {2}\n Student Name: {3}\n StudentDOB: {4}\n CID: {5}\n Cname: {6}\n Cduration: {7}\n Fees: {8}\n",dr[0],dr[1].ToString(),dr[2],dr[3],dr[4],dr[5],dr[6],dr[7],dr[8] );

                    }
                }
              
                else
                {
                    Console.WriteLine("there is no data to display");
                }
                Console.WriteLine("***********************************************");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Error in the Server...");
                displayEnrollments();
            }
        }

    }
}
