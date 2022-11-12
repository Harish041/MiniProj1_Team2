using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Mini_Proj_1_Team_2
{
    class App:UserInterface
    {
        static void Main(string[] args)
        {

            AppEngine a1 = new AppEngine();

           // Console.WriteLine("enter how many details want to store and maximum limit is 5");
            //int input = Convert.ToInt32(Console.ReadLine());
            Course c = new Course();
            // a1.register(input);
            //a1.introduce(input);
            //a1.listOfCourses(c);
            Student s = new Student();
            a1.enroll(s,c);
            a1.listOfEnrollments();
           





            // userinterface
            //App a = new App();
            //a.showFirstScreen();
            // Console.Read();


            // a.listOfStudents();

            //bool isPrint;
            //Console.WriteLine("do you want to print Y for yes N for no");
            //char printing = Convert.ToChar(Console.ReadLine());




            //App a = new App();
            //a.Scenario1();
            //a.Scenerio2();
            //a.Scenerio3();
            Console.Read();
        }
        

    //- Write a method called as scenario1 to:
	//- Create few objects of Student class
	//- Call the Display method of Info class
        //public void Scenario1()
        //{
        //    Student std1 = new Student();
        //    Student std2 = new Student();
        //    Student std3 = new Student();
        //    Student std4 = new Student();//student class obj.
        
        //    Info i1 = new Info(); // class info obj.
            
        //    std1.ID = 1;
        //    std1.Name = "Harish";
        //    std1.dob = Convert.ToDateTime("04/01/2000");
           
        //    std2.ID = 2;
        //    std2.Name = "Siva";
        //    std2.dob = Convert.ToDateTime("05/02/2001");
            
        //    std3.ID = 3;
        //    std3.Name = "Jaya";
        //    std3.dob = Convert.ToDateTime("12/10/2002");
            
        //    std4.ID = 4;
        //    std4.Name = "Sathish";
        //    std4.dob = Convert.ToDateTime("2003/12/21");
            
        //    i1.SDisplay(std1);
        //    i1.SDisplay(std2);
        //    i1.SDisplay(std3);
        //    i1.SDisplay(std4);
        //}


 //        - Write a method called as scenario2 to:
	//- Create array of Student class and store few objects in it
	//- Demonstrate how to iterate over the array and call the Display method for each student

        //public void Scenerio2()
        //{
            
        //    var std = new Student[4];//array of objects
        //    Info val = new Info(); //obj creation
            
            
        //    std[0] = new Student();
        //    std[1] = new Student();
        //    std[2] = new Student();
        //    std[3] = new Student();
               
            
        //    std[0].ID = 1;
        //    std[0].Name = "Sweta";
        //    std[0].dob = Convert.ToDateTime("2001/02/12");


        //    std[1].ID = 2;
        //    std[1].Name = "Rekha";
        //    std[1].dob = Convert.ToDateTime("2007/12/22");


        //    std[2].ID = 3;
        //    std[2].Name = "Santhosh";
        //    std[2].dob = Convert.ToDateTime("2010/02/11");


        //    std[3].ID = 4;
        //    std[3].Name = "Shivan";
        //    std[3].dob = Convert.ToDateTime("2008/09/21");
            
        //    foreach(var i in std)
        //    {
        //        val.SDisplay(i); //val is the object of info class using that caling display method of class info.
        //    }
        //    Console.WriteLine();

        //}

 //       - Write a method called as scenario3 to:
	//- Take Student data as input from the user, store it in Student object
	//- Repeat the above process using loops
	//- Use Arrays to store the Student objects as covered in scenario2
	//- Finally iterate over the array to Display all the collected data
        //public void Scenerio3()
        //{
        //    Console.Write("enter how many student details need to enter: ");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    Student[] std = new Student[input];
        //    Info i = new Info();
        //    for(int IndexVal =0; IndexVal < std.Length; IndexVal++)  //storing values  in the array of objects based on IndexVal value in the student array 
        //    {
        //        std[IndexVal] = new Student(); // 'IndexVal' represents array index value of objects
        //        Console.WriteLine("Enter Student Id");
        //        std[IndexVal].ID = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Student Name");
        //        std[IndexVal].Name = Console.ReadLine();
        //        Console.WriteLine("Enter Date of birth for the student");
        //        std[IndexVal].dob = Convert.ToDateTime(Console.ReadLine());
        //    }

            //foreach (var a in std) //calling display method located in info class.
            //{
            //    i.SDisplay(a); //'i' is the object of info class 
            //}

       // }


    }

    public class Student
    {
        int id;
        string name;
        DateTime DOB;
        Student[] s = new Student[3];
        //public Student(int id,string name,string DOB)
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

    public  class Course
    {
        int CourseId;
        string Name;
        DateTime Duration;
        float Fees;

        public int cid
        {
            get { return CourseId; }
            set { CourseId = value; }
        }
        public string name 
        {
            get {return Name; }
            set {Name = value; }
        }
        public DateTime duration
        {
            get { return Duration; }
            set {Duration = value; }
        }
        public float fee 
        {
            get { return Fees; }
            set { Fees = value; } 
        }
    }

    class Info
    {
        public void SDisplay(Student student)
        {

            Console.WriteLine("Student ID: {0}", student);
            Console.WriteLine("Student Name: {0}", student.Name);
            Console.WriteLine("Student DOB: {0}", student.dob.ToShortDateString());
            Console.WriteLine();
        }
        public void CDisplay(Course course)
        {
            Console.WriteLine("Course ID: " + course.cid);
            Console.WriteLine("Course Name: " + course.name);
            Console.WriteLine("Course Duration: " + course.duration);
            Console.WriteLine("Course Fees: " + course.fee);
        }
    }

}
