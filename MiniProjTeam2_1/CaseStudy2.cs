using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjTeam2_1
{
    class CaseStudy2
    {
    }

    public class Course
    {
        public int cid { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
        public float fee { get; set; }
    }

    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime EnrollmentDate;

        public Student std
        {
            get { return student; }
            set { student = value; }
        }
        public Course crs
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime enrollDate
        {
            get { return EnrollmentDate; }
            set { EnrollmentDate = value; }
        }


    }
    public class AppEngine
    {
        int val = 0;
        Student[] s = new Student[100];
        List<Course> courses = new List<Course>(5);
        List<Enroll> e = new List<Enroll>();
        Course[] c = new Course[100];
        Enroll[] enroll = new Enroll[10];

        public void introduce(Course course)
        {
            Console.WriteLine("how many Course data want to Insert");
            val = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < val; i++)
            {

                Console.WriteLine("Enter Course Id");
                course.cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name");
                course.name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration");
                course.duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fees");
                course.fee = Convert.ToSingle(Console.ReadLine());

                c[i] = new Course()
                {
                    cid = course.cid,
                    name = course.name,
                    duration = course.duration,
                    fee = course.fee,
                };
                

            }
        }

        //        public void Introduce()
        //{
        //    Program.CourseRegistration();
        //}

        public void register(Student student)
        {
            try
            {
                Console.WriteLine("enter how many student data want to register\n");
                val = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < val; i++)
                {
                    Console.WriteLine("Enter Student Id");
                    student.ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Student Name");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("Enter Student Dob");
                    student.dob = DateTime.Parse(Console.ReadLine());
                    s[i] = new Student()
                    {
                        ID = student.ID,
                        Name = student.Name,
                        dob = student.dob,
                    };
                }
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Error:  Check the Inputs which you have given");
            }
            
        }
        //public void register()
        //{
        //    Program.StudentRegistration();
        //}

        //public void listOfStudents()
        //{
        //    Program.displayStudent();
        //   // return s;

        //}
        public Student[] listOfStudents()
        {
            Console.WriteLine();
            for (int i = 0; i < val; i++)
            {
                s[i] = new Student()
                {
                    ID = s[i].ID,
                    Name = s[i].Name,
                    dob = s[i].dob,
                };
            }


            //    Program.displayStudent();

            return s;

        }

        public List<Course> listOfCourses()
        {

            for (int i = 0; i < val; i++)
            {
                courses =(new List<Course> { 
                          new Course{cid = courses[i].cid,name =courses[i].name, duration = courses[i].duration,fee = courses[i].fee}
                        });
            }

            return courses;
        }
        //        public void listOfCourses()
        //{
        //    Program.displayCourse();
        //}
        public void Enroll(Student student, Course course)
        {
            Enroll e2 = new Enroll();
            Console.WriteLine("enter how many student details needs to enroll\n NOTE: Maximum limit is 10 in a Time");
            val = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Enter Student ID");
                student.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter Course Id");
                course.cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name");
                course.name = Console.ReadLine();
                e2.enrollDate = Convert.ToDateTime(DateTime.Now);//datetime.now is used to give the todays date
                //student.AddRange(new List<Student> {
                //   new Student { ID = id,Name = name},
                //});
                //course.AddRange(new List<Course> {
                //   new Course {cid = Cid,name = CName},
                //});
                //e.AddRange(new List<Student> { 
                //)};

                s[i] = new Student() //  student object intiallizer
                {
                    ID = student.ID,
                    Name = student.Name,
                };
                c[i] = new Course() //course obj initiallizer
                {
                    cid = course.cid,
                    name = course.name,
                };
                enroll[i] = new Enroll() //enroll object initiallizer
                {
                    enrollDate = e2.enrollDate,
                };




            }
        }

        public Enroll[] listOfEnrollments()
        {
            for (int i = 0; i < val; i++)
            {

                enroll[i] = new Enroll()
                {
                    std = new Student
                    {
                        ID = s[i].ID,
                        Name = s[i].Name,
                    },
                    crs = new Course()
                    {
                        cid = c[i].cid,
                        name = c[i].name,
                    },
                    enrollDate = enroll[i].enrollDate,

                };
            }
            return enroll;
        }

       

       


    }
}
