using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter marks in pre-exam:");
                int preMarks = Convert.ToInt32(Console.ReadLine());

                if (preMarks > 60)
                {
                    Console.WriteLine("Enter marks in final exam:");
                    int finalMarks = Convert.ToInt32(Console.ReadLine());

                    if (finalMarks > 55)
                    {
                        Console.WriteLine("Selected");
                    }
                    else
                    {
                        Console.WriteLine("Fail in Final");
                    }
                }
                else
                {
                    Console.WriteLine("Fail in Pre");
                }

                Console.ReadLine();
            }
        }
    }
}
