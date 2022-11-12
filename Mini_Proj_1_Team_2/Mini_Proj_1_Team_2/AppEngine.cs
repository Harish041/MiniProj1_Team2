using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Proj_1_Team_2
{


    class Enroll
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
    class AppEngine
    {
        int val;
        Student[] s = new Student[5];
        List<Course> courses = new List<Course>();
        Course[] c = new Course[5];
        Enroll[] e = new Enroll[5];
        public void introduce(int input)
        {

            for (int i = 0; i < input; i++)
            {

                Console.WriteLine("Enter Course Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration");
                DateTime Duration = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Course Fees");
                float Fee = Convert.ToSingle(Console.ReadLine());
                courses.AddRange(new List<Course> {
                   new Course {cid = id,name = Name,duration = Duration,fee = Fee },
                });
                
            }
        }

        public void register(int input)
        {
            Console.WriteLine("enter how many student details needs to register\n NOTE: Maximum limit is 5");
            val = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Enter Stdid, Stdname,Dob");
               int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                DateTime Dob = DateTime.Parse(Console.ReadLine());
                s[i] = new Student()
                {
                    ID = id,
                    Name = name,
                    dob = Dob,
                };
            }
          
        }

    public Student[] listOfStudents(int input)
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
            for (int i = 0; i < val; i++)
            {
                Console.WriteLine(s[i].ID + s[i].Name + s[i].dob.ToShortDateString());
            }
            return s;

        }

        public List<Course> listOfCourses(Course[] course)
        {

            for (int i = 0; i < val; i++)
            {
                courses = new List<Course>
                {
                    new Course{cid = course[i].cid,name = course[i].name,duration = course[i].duration,fee = course[i].fee}
                };
            }
                foreach(var a in courses)
                {
                    Console.WriteLine(" course Id: {0}\n Course Name: {1}\n Course Duration: {2}\n Course Fee: {3}\n ",a.cid,a.name,a.duration.ToShortDateString(),a.fee);
                }
                
                
            return courses;
        }

        public void enroll(Student student, Course course)
        {
            Console.WriteLine("enter how many student details needs to enroll\n NOTE: Maximum limit is 5");
            val = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Enter Stdid, Stdname");
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                Console.WriteLine("Enter Course Id");
                int Cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name");
                string CName = Console.ReadLine();
                DateTime enrollment = Convert.ToDateTime(DateTime.Now);

                s[i] =  new Student()
                {
                    ID = id,
                    Name = name,
                };
                c[i] = new Course()
                {
                    cid = Cid,
                    name = CName,
                };
                e[i] = new Enroll()
                {
                    enrollDate = enrollment,
                };



            }
        }

        public Enroll[] listOfEnrollments()
        {
            for (int i = 0; i < val; i++)
            {
                s[i] = new Student()
                {
                    ID = s[i].ID,
                    Name = s[i].Name,
                };
                c[i] = new Course()
                {
                    cid = c[i].cid,
                    name = c[i].name,
                };
                e[i] = new Enroll()
                {
                    enrollDate = e[i].enrollDate,
                };
            }
            for(int i = 0; i < val; i++)
            {
                Console.WriteLine(" \nStudent ID: {0} \nStudent Name: {1} \nCourse ID: {2} \nCourse Name: {3} \nEnrollment Date: {4}", s[i].ID, s[i].Name, c[i].cid, c[i].name, e[i].enrollDate.ToShortDateString()); ;
            }
            return e;
        }
    }
}
