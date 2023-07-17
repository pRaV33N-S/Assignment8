using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        public  int calculation(int hours,int days,int handles=0,int extras=0)
        {
            int result = hours * days * 100 + handles * 3000 + extras * 2000;
            return result;
        }
        static void Main(string[] args)
        {
            Program instance = new Program();
            Console.WriteLine("Enter Employee Type");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the number of working hours");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of working days");
            int days = int.Parse(Console.ReadLine());
            if (type.Equals("HR"))
            {
                Console.WriteLine("Salary : " + instance.calculation(hours,days));
            }
            else if (type.Equals("Admin"))
            {
                Console.WriteLine("Enter the number of working handles");
                int handles = int.Parse(Console.ReadLine());
                Console.WriteLine("Salary : " + instance.calculation(hours,days,handles));
            }
            else if (type.Equals("SE"))
            {
                Console.WriteLine("Enter the number of working handles");
                int handles = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of working extras");
                int extras = int.Parse(Console.ReadLine());
                Console.WriteLine("Salary : "+instance.calculation(hours, days, handles,extras));
            }
        }
    }
}
