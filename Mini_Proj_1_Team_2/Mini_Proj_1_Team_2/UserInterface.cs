using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Proj_1_Team_2
{
    public abstract class UserInterface
    {
        AppEngine a = new AppEngine();
        Course[] c = new Course[3];
        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to the student Management App");
            Console.WriteLine("select one option from below. \n1.Student \n 2.Admin");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default: Console.WriteLine("invalid input select from the given option");
                    break;
            }
        }
		public void showStudentScreen()
        {
            
           start:
            Console.WriteLine("Student Screen ");
            Console.WriteLine("1. Register new student\n2.Show the list of students\n3. to exit");
            Console.WriteLine("select the required action you want to proceed");
            int showStudentScreeninput = Convert.ToInt32(Console.ReadLine());
            
                switch (showStudentScreeninput)
                {
                    case 1:
                        showStudentRegistrationScreen();
                        break;
                    case 2:
                        showAllStudentsScreen();
                        break;
                case 3:
                    Console.WriteLine("Are you sure want to exit Y/N:");
                    char exitVal = Convert.ToChar(Console.ReadLine().ToUpper());
                    
                    if (exitVal == 'Y')
                    {
                        Console.WriteLine("Exiting.....");
                        showFirstScreen();
                    }else if(exitVal == 'N')
                    {
                        Console.WriteLine("invalid Input");
                        goto start;
                    }
                    else
                    {
                        break;
                    }
                    break;

                    default:
                        Console.WriteLine("enter the any one input from the above option: ");
                        break;
                }
           
            if(showStudentScreeninput != 3)
            {
                goto start;
            }
        }
		public void showAdminScreen()
        {
            Console.WriteLine("Admin Screen ");
            Console.WriteLine("1.Show the list of students\n2. Register new student\n3.Update detail\n4.Delete detail");
            Console.WriteLine("select the required action you want to proceed");
            int showStudentScreeninput = Convert.ToInt32(Console.ReadLine());
            switch (showStudentScreeninput)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                case 3:
                    Console.WriteLine("update function");
                    break;
                case 4:
                    Console.WriteLine("delete function");
                    break;
                default:
                    Console.WriteLine("enter the any one input from the above option: ");
                    break;
            }
        }
		public void showAllStudentsScreen()
        {
           // Console.WriteLine("lst of stdnt");
            a.listOfStudents(2);

        }
        public void showStudentRegistrationScreen()
        {
           // Console.WriteLine("register std");
            
            a.register(2);
        }
		public void introduceNewCourseScreen()
        {
            a.introduce(2);
        }
		public void showAllCoursesScreen()
        {
            a.listOfCourses(c);
        }
	}
}
