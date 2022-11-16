using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjTeam2_1
{
    class CaseStudy1
    {
    }
    class App:UserInterface
    {
        static void Main(string[] args)
        {

            App a = new App();
            a.showFirstScreen();
            //a.Scenario1();
            //a.Scenerio2();
            //a.Scenerio3();



            AppEngine a1= new AppEngine();
            Course c1 = new Course();
            Student s1 = new Student();
            Info i1 = new Info();
            //a1.Enroll(s1, c1);
            //var enrollval = a1.listOfEnrollments();
            //for (int i = 0; i < enrollval.Count(); i++)
            //{
            //    if (enrollval[i] != null)
            //    {
            //        i1.EDisplay(enrollval[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("press enter key to Exit");
            //        break;
            //    }
            //}
            //CaseStudy4.DeleteStudent(s1
            //    );


            //a1.introduce(c1);
            //var courseVal = a1.listOfCourses();
            //foreach(var a in courseVal)
            //{

            //        i1.SCourse(a);

            //}


            //a.register(s1);
            //Student[] s = new Student[10];

            //var studentVal = a.listOfStudents();

            //// int count = studentVal.Count();
            //for (int i = 0; i < studentVal.Count(); i++)
            //{

            //    if (studentVal[i] != null)
            //    {
            //        i1.SDisplay(studentVal[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Press Enter Key to Exit");
            //        break;
            //    }
            //}



            Console.Read();

        }

    }
  public class Info
    {
        public void SDisplay(Student student)
        {
            //Program.displayStudent();
            Console.WriteLine("********************************");
            Console.WriteLine("Student ID: {0}", student.ID);
            Console.WriteLine("Student Name: {0}", student.Name);
            Console.WriteLine("Student DOB: {0}", student.dob.ToShortDateString());
            Console.WriteLine("********************************");
            Console.WriteLine();
        }

        //case study - 2
        public void SCourse(Course course)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Course ID: {0}", course.cid);
            Console.WriteLine("Course Name: {0}", course.name);
            Console.WriteLine("Course Duration: {0}", course.duration);
            Console.WriteLine("Course Fees: {0}", course.fee);
            Console.WriteLine("********************************");
            Console.WriteLine();
        }

        //case study - 2
        public void EDisplay(Enroll enroll)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Student ID: {0}", enroll.std.ID);
            Console.WriteLine("Student Name: {0}", enroll.std.Name);
            Console.WriteLine("Course Id: {0}", enroll.crs.cid);
            Console.WriteLine("Course Name: {0}", enroll.crs.name);
            Console.WriteLine("Enrollment Date: {0}", enroll.enrollDate.ToShortDateString());
            Console.WriteLine("********************************");
        }

    }

  public  class Student
    {
        int id;
        string name;
        DateTime DOB;

        //public Student(int id, string name, string DOB)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.DOB = Convert.ToDateTime(DOB);
        //}
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }

    }
}
