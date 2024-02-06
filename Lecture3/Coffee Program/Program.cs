using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool another_order = true;
            int choice;
            do
            {
                Console.WriteLine("");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
          

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("aa");
                }
            }while(another_order);
        }
    }
}
