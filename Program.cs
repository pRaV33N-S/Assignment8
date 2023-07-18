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
            char choice;
            do
            {
                try
                {
                    Console.WriteLine("Choose the Employee Type");
                    Console.WriteLine("1. HR");
                    Console.WriteLine("2. Admin");
                    Console.WriteLine("3. Software Engineer");
                    int type = int.Parse(Console.ReadLine());
                    if (type == 1)
                    {
                        Console.WriteLine("Enter the number of working hours");
                        int hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working days");
                        int days = int.Parse(Console.ReadLine());
                        Console.WriteLine("Salary : " + instance.calculation(hours, days));
                    }
                    else if (type == 2)
                    {
                        Console.WriteLine("Enter the number of working hours");
                        int hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working days");
                        int days = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working handles");
                        int handles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Salary : " + instance.calculation(hours, days, handles));
                    }
                    else if (type == 3)
                    {
                        Console.WriteLine("Enter the number of working hours");
                        int hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working days");
                        int days = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working handles");
                        int handles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number of working extras");
                        int extras = int.Parse(Console.ReadLine());
                        Console.WriteLine("Salary : " + instance.calculation(hours, days, handles, extras));
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Employee Type");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error has happened!!! \n" + e.Message);
                }
                finally
                {
                    Console.WriteLine("Would you like to Check other Employee?");
                    Console.WriteLine("Click Y to Yes \t Other Key to No");
                    choice = char.Parse(Console.ReadLine());
                }
            } while (choice == 'Y');
        }
    }
}
