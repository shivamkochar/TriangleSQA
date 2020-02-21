using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean check;
            int dimension1 = 0;
            int dimension2 = 0;
            int dimension3 = 0;
            String result;

            do
            {
                check = true;
                try
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter triangle dimension");
                    Console.WriteLine("2. Exit");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        dimension1 = CheckDimension();

                        dimension2 = CheckDimension();

                        dimension3 = CheckDimension();
                    }  

                    else if(choice == 2)
                    {
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.WriteLine("Please select the valid option");
                    }
                } 
                catch (Exception)
                {
                    Console.WriteLine("Enter the valid input");
                }
            } while (check == true);

            result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);
            Console.WriteLine(result);
            Console.ReadLine();

            int CheckDimension()
            {
                int dimension = 0;
                do
                {
                    check = true;
                    try
                    { 
                        Console.WriteLine("Enter the dimension");
                        dimension = int.Parse(Console.ReadLine());
                        if(dimension <= 0)
                        {
                            Console.WriteLine("Enter the dimension greater than zero");
                            check = true;
                        }
                        else
                        {
                            Console.WriteLine("Dimension entered successfully");
                            check = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter the valid dimension");
                        check = true;
                    }
                } while (check == true);
                return dimension;
            }
        }

    }
}
        
    

