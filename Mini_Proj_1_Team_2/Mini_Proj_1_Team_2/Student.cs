using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-Create Student class (id, name, dateofbirth)
// - Cover constructors, getters and setters


namespace Mini_Proj_1_Team_2
{
    public class Student
    {
        int id;
        string name;
        DateTime DOB;

        //public Student(int id,string name,string DOB)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.DOB = Convert.ToDateTime(DOB);
        //}
        public int ID { get; set; }
        public string Name {get;set;}
        public DateTime dob { get; set; }
    }

   

}
