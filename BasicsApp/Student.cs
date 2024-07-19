using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    internal class Student
    {
        static int Rollno = 1;


        public static int GenerateRollNo() {

            Rollno = Rollno+ 1;
            return Rollno;
        
        }

    }
}
