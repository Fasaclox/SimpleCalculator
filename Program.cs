using System;

namespace Helloworld_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

Line1:      Console.Write("Enter your first number ");
            int Firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please pick a function sign to perform");
            Console.WriteLine("from +, -, *, /");
            string sign = Console.ReadLine();
            Console.Write("Enter second number ");
            int Secondnumber = Convert.ToInt32(Console.ReadLine());
           
            


            if (!string.IsNullOrEmpty(sign))
            {
                if (sign == "+")
                {
                    Console.WriteLine("Sum of numbers = " + (Firstnumber + Secondnumber));
                    Console.WriteLine("Do you want to perform another function? Yes / No");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        goto Line1;
                    }
                    else
                        Console.WriteLine("bye now");
                }
                else if (sign == "-")
                {
                    Console.WriteLine("Substratction of number = " + (Firstnumber - Secondnumber));
                    Console.WriteLine("Do you want to perform another function? Yes / No");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        goto Line1;
                    }
                    else
                        Console.WriteLine("bye now");
                }
                else if (sign == "*")
                {
                    Console.WriteLine("Multiplication of number = " + (Firstnumber * Secondnumber));
                    Console.WriteLine("Do you want to perform another function? Yes / No");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        goto Line1;
                    }
                    else
                        Console.WriteLine("bye now");
                }
                else if (sign == "/")
                {
                    Console.WriteLine("Division of numbers = " + (Firstnumber / Secondnumber));
                    Console.WriteLine("Do you want to perform another function? Yes / No");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        goto Line1;
                    }
                    else
                        Console.WriteLine("bye now");
                    

                }
                else
                    Console.WriteLine("Please input a function");
                    Console.ReadLine();
                     
                {


                }


            }
        }
    }
}
