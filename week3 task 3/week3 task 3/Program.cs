using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your final mark: ");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Grade = A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Grade = A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Grade = B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Grade = B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Grade = C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Grade = D");
            else if (mark >= 30 && mark <= 39)
                Console.WriteLine("Grade = F");
            else
                Console.WriteLine("mark not avaliable");

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
