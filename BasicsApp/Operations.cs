using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
   public static    class Operations
    {
        static float p = 33;//static variable allowed in nonstatic class as well as static class
         int v1 = 10;//non static varibale cannot be declard in static class

         void M1()
        {
            static int p1 = 100;//non static method cannot have static varible
            p = p + 10;
            v1 = v1 + 10;

        }

        static void M2()
        {
          static int  p2 = p2 + 100;//static method cannot have static variable
            int p1 = 33;//Non static variable allowed in static method

        
        }
    }
}
