using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "Noppa";
            somebody.LastName = "Nipples";
            somebody.Address = "twitch.tv";
            somebody.Age = 10;
            somebody.PhoneNumber = "112";

            Console.WriteLine(somebody.ToString());


            Teacher teacher = new Teacher();
            teacher.FirstName = "Dendi";
            teacher.LastName = "PugeRU";
            teacher.Address = "Dota2";
            teacher.Age = 24;
            teacher.PhoneNumber = "19-0-32";
            teacher.Room = "BottomLane";
            Console.WriteLine(teacher.ToString());

            Student theStudent = new Student("Dr", "Pepper", "9001");
            theStudent.Address = "olutta";
            theStudent.Age = 10;
            theStudent.PhoneNumber = "93865310";
            Console.WriteLine(theStudent.ToString());

            somebody.PersonMethod();
            
            teacher.TeacherMethod();
           
            theStudent.StudentMethod();

            Console.ReadLine();


        }
        
    }

    
}
