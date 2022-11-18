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
            try
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
            catch(FormatException fe)
            {
                Console.WriteLine("Error : Invalid input type");
                showFirstScreen();
            }
        }
        public void showStudentScreen()
        {

        start:
            try
            {
                Console.WriteLine("***************Student Screen****************");
                Console.WriteLine("1.Show the list of students\n2.Show the list of Courses \n3. Exit from Student Screen\n4. Exit from Application");
                Console.WriteLine("select the required choice of  action you want to proceed");
                int showStudentScreeninput = Convert.ToInt32(Console.ReadLine());

                switch (showStudentScreeninput)
                {
                    case 1:
                        CaseStudy4.displayStudent();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 2:
                        //showAllStudentsScreen();
                        CaseStudy4.displayCourse();
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
                    case 4:
                        Console.WriteLine("press enter to exit");
                        break;

                    default:
                        Console.WriteLine("enter the any one input from the given option: ");
                        goto start;
                       
                }

                if (showStudentScreeninput != 3 && showStudentScreeninput !=4)
                {
                    goto start;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Error: invalid input");
                goto start;
            }
        }
        public void showAdminScreen()
        {
        StartAdmin:
            try
            {
                Console.WriteLine("\n************Admin Screen******************");
                Console.WriteLine("\n1. Register new Course\n2.To Show the list of Course\n3.Register new Student\n4.Display Student list\n5.Update detail\n6.New Enrollment\n7.List of Enrollments\n8.Exit Admin Screen\n9.Exit Application");
                Console.WriteLine("select the required action you want to proceed");
                int showCourseScreeninput = Convert.ToInt32(Console.ReadLine());
               
                switch (showCourseScreeninput)
                {
                    case 1:
                        //introduceNewCourseScreen();
                        Console.WriteLine("*********************Course Screen*****************\n");
                        Console.WriteLine("\nRegistered Courses");
                        CaseStudy4.displayCourse();
                        CaseStudy4.CourseRegistration(c);
                        break;
                    case 2:
                        Console.WriteLine("*********************Course Screen*****************\n");
                        CaseStudy4.displayCourse();
                        break;
                    case 3:
                        Console.WriteLine("\nRegistered Students");
                        CaseStudy4.StudentRegistration(s);
                        break;
                    case 4:
                        CaseStudy4.displayStudent();
                        break;
                    case 5:
                        Console.WriteLine("***********Update details**********\nselect the which detail you want to update:\n1.Update Student\n2.Exit from update screen\n3.Exit from Admin screen");
                        int input = Convert.ToInt32(Console.ReadLine().ToUpper());
                        switch (input)
                        {
                            case 1:
                                CaseStudy4.displayStudent();
                                Console.WriteLine("****************************");
                                CaseStudy4.UpdateStudent(s);
                                Console.WriteLine("****************************");
                                CaseStudy4.displayStudent();
                                break;
                            case 2:
                                goto StartAdmin;

                            case 3:
                                showFirstScreen();
                                break;
                            default:
                                Console.WriteLine("enter valid input");
                                goto StartAdmin;


                        }
                        break;
                    case 6:
                        Console.WriteLine("***************Enrollment screen***************");
                        CaseStudy4.Enroll(s, c);
                        break;
                    case 7:
                        Console.WriteLine("**************List of Enrolled Students*************");
                        CaseStudy4.displayEnrollments();
                        break;
                    case 8:
                        Console.WriteLine("Press enter key to exit.. from Admin Screen");
                        showFirstScreen();
                        break;
                    case 9:
                        Console.WriteLine("press enter to exit");
                        break;
                    default:
                        Console.WriteLine("enter the any one input from the above option: ");
                        goto StartAdmin;
                        
                }
                if (showCourseScreeninput != 8  && showCourseScreeninput !=9)
                {
                    goto StartAdmin;
                }
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Error: Invalid data");
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
