using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//- Create class Info
//  -Write a method called as:
//	public void display(Student student)
//{
//    //Code here to display the details of given student
//}

namespace Mini_Proj_1_Team_2
{
    class Info
    {
        public void SDisplay(Student student)
        {

            Console.WriteLine("Student ID: {0}", student.ID);
            Console.WriteLine("Student Name: {0}",student.Name);
            Console.WriteLine("Student DOB: {0}",student.dob.ToShortDateString());
            Console.WriteLine();
        }
        public void CDisplay(Course course)
        {
            Console.WriteLine("Course ID: "+course.cid);
            Console.WriteLine("Course Name: "+course.name);
            Console.WriteLine("Course Duration: "+course.duration);
            Console.WriteLine("Course Fees: "+course.fee);
        }
    }
}
