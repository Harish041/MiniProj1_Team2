using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjTeam2_1
{
    class CaseStudy3
    {
    }

    public abstract class UserInterface
    {
        AppEngine a = new AppEngine();
        Course c = new Course();
        Student s = new Student();
        Info i1 = new Info();

        public void showFirstScreen()
        {

            Console.WriteLine("Welcome to the student Management App");
        StartFirstscreen:
            Console.WriteLine("***************************************************");
            Console.WriteLine("select the user type option from below.\n1.Student \n2.Admin\n3.To Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("press Enter key to exit..");
                    break;
                default:
                    Console.WriteLine("Invalid Input select the correct user type to proceed");
                    goto StartFirstscreen;
            }
        }
        public void showStudentScreen()
        {

        start:
            Console.WriteLine("***************Student Screen****************");
            Console.WriteLine("1. Register new student\n2.Show the list of students\n3. Exit from Student Screen");
            Console.WriteLine("select the required choice of  action you want to proceed");
            int showStudentScreeninput = Convert.ToInt32(Console.ReadLine());

            switch (showStudentScreeninput)
            {
                case 1:
                    CaseStudy4.StudentRegistration(s);
                   // showStudentRegistrationScreen();
                    Console.WriteLine();
                    break;
                case 2:
                    //showAllStudentsScreen();
                    CaseStudy4.displayStudent();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Are you sure want to exit Y/N:");
                    char exitVal = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (exitVal == 'Y')
                    {
                        Console.WriteLine("Exiting.....");
                        showFirstScreen();
                    }
                    else if (exitVal == 'N')
                    {
                        // Console.WriteLine("\n");
                        goto start;
                    }

                    break;

                default:
                    Console.WriteLine("enter the any one input from the given option: ");
                    break;
            }

            if (showStudentScreeninput != 3)
            {
                goto start;
            }
        }
        public void showAdminScreen()
        {
        StartAdmin:
            Console.WriteLine("Admin Screen ");
            Console.WriteLine("\n1. Register new Course\n2.Show the list of Course\n3.Update detail\n4.Delete detail\n5.Exit Admin Screen");
            Console.WriteLine("select the required action you want to proceed");
            int showCourseScreeninput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************Course Screen*****************\n");
            switch (showCourseScreeninput)
            {
                case 1:
                    //introduceNewCourseScreen();
                   
                    Console.WriteLine("Courses Available already\n");
                    CaseStudy4.displayCourse();
                    CaseStudy4.CourseRegistration(c);
                    break;
                case 2:
                    //showAllCoursesScreen();
                    Console.WriteLine("Courses Available already\n");
                    CaseStudy4.displayCourse();
                    break;
                case 3:
                    Console.WriteLine("***********Update details**********\nselect the which detail you want to update:\n1.Update Student\n.2.Update Course\n3.Exit from update screen\n4.Exit from Admin screen");
                    int input = Convert.ToInt32(Console.ReadLine().ToUpper());
                    switch (input)
                    {
                        case 1:
                            CaseStudy4.UpdateStudent(s);
                            break;
                        case 2:
                            CaseStudy4.UpdateCourse(c);
                            break;
                        case 3:
                            goto StartAdmin;

                        case 4:
                            showFirstScreen();
                            break;
                        default:
                            Console.WriteLine("enter valid input");
                            goto StartAdmin;


                    }
                    break;
                case 4:
                    Console.WriteLine("delete function\n1.Delete data from Student\n2.Delete data from Course\n3.Exit from Delete screen\n4.Exit from Admin screen ");
                    int deleteInput = Convert.ToInt32(Console.ReadLine());
                    switch (deleteInput)
                    {
                        case 1:
                            CaseStudy4.DeleteStudent(s);
                            break;
                        case 2:
                            Console.WriteLine("delete course");
                            break;
                        case 3:
                            goto StartAdmin;

                        case 4:
                            showFirstScreen();
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            goto StartAdmin;

                    }
                    break;
                case 5:
                    Console.WriteLine("Press enter key to exit..");
                    break;
                default:
                    Console.WriteLine("enter the any one input from the above option: ");
                    break;
            }
            if (showCourseScreeninput != 5)
            {
                goto StartAdmin;
            }
        }
        public void showAllStudentsScreen()
        {

            CaseStudy4.displayStudent();
           //  var studentVal = a.listOfStudents();

            // int count = studentVal.Count();
            //for (int i = 0; i < studentVal.Count(); i++)
            //{

            //    if (studentVal[i] != null)
            //    {
            //        i1.SDisplay(studentVal[i]);
            //    }
            //    else
            //    {
            //        showStudentScreen();
            //    }
               
            //}

        }
        public void showStudentRegistrationScreen()
        {
            // Console.WriteLine("register std");

            a.register(s);
        }
        public void introduceNewCourseScreen()
        {
            // a.introduce();
            a.introduce(c);
        }
        public void showAllCoursesScreen()
        {
            var courseVal = a.listOfCourses();
            for (int i = 0; i < courseVal.Count(); i++)
            {
                if (courseVal[i] != null)
                {
                    i1.SCourse(courseVal[i]);
                }
                else
                {
                    showAdminScreen();
                }
            }
        }

    }
}
