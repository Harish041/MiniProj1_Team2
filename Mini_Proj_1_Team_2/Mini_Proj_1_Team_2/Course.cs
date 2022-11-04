using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Proj_1_Team_2
{
//    Now create Course class (id, name, duration, fees)
//  - Modify Info class by adding one more method:
//	public void display(Course course)
//    {
		//Code here to display the details of given course
    class Course
    {
        int CourseId;
        string Name;
        DateTime Duration;
        float Fees;

        public int cid { get; set; }
        public string name { get; set; }
        public DateTime duration { get; set; }
        public float fee { get; set; }
    }
}
