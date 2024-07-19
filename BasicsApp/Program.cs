using BasicsApp;
using System.ComponentModel;
using System.IO.Pipes;

internal class Program
{
  
    private static void Main(string[] args)
    {

        Student s=new Student();
        Student.


        char ans = 'Y';
        do
        {
            Console.WriteLine("\n1.Add New Student \n2.Edit a Student \n3.Exit");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    int rno = Student.GenerateRollNo();
                    Console.WriteLine($"The rollno= {rno}");

                    break;
                case 2:
                    Console.WriteLine("Work in progress.....");
                    break;
                case 3:
                    Environment.Exit(1);

                    break;

            }

            Console.WriteLine("Do u want to add one more student?");
             ans=Convert.ToChar(Console.ReadLine());
            if (ans =='N')
                Environment.Exit(1);
        }
        while (ans=='Y');
        //Console.WriteLine("Enter first number");
        //int fno = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter second number");
        //int sno = Int32.Parse(Console.ReadLine());
        //SubtractNos(fno, sno);

        File




        //        AcceptAndAddTwoNumbers();



        //UnderstandingBoxingUnboxing();

        //Int32 j = 100;
        //float pi = 3.14f;
        //Single t = 4.45f;
        //char c = 'A';
        //double y = 23242.23;
        //string s = "hello";
        //DateTime dt = DateTime.Now;
        //Console.WriteLine(dt);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(pi);
        //Console.WriteLine(t);
        Console.Read();
    }

    private static void SubtractNos(int fno, int sno)
    {
        if (sno == 0)
        {
            int subtract = fno - sno;
        }
        else
        {
            Console.WriteLine("Second number must be non zero...");
        }
    }

    private static void AcceptAndAddTwoNumbers()
    {
        Console.WriteLine("Enter first number");
        int fno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int sno = Int32.Parse(Console.ReadLine());

        int add = fno + sno;
        Console.WriteLine($"The addition of {fno} + {sno}={add}");
    }

    private static void UnderstandingBoxingUnboxing()
    {
        int i = 100;
        object o;
        o = i;//o=100
        int k = (int)o;//k=100
        float f1 = 233.10f;
        double d1 = k * f1;
        Console.WriteLine($"The value of d1={d1}");
        Console.WriteLine("The type of d1= " + d1.GetType());
        o = d1;//double value

        Console.WriteLine("The type of o=" + o.GetType());
        Console.WriteLine($"Value of o={o}");
        double j;
        j = (double)o;
        Console.WriteLine(j);
    }
}