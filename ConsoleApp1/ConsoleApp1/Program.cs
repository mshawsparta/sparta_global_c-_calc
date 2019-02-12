using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Program
    {
        

        static void Main()
        {
            //
            Console.Write("Press 1 for simple calculator and 2 for advanced ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter an operator: ");
                string op = Console.ReadLine();
                

                switch (op)
                {
                    case "+":
                        Console.WriteLine("The anwser is: "+ (num1 + num2) );
                        Console.Read();
                        break;

                    case "-":
                        Console.WriteLine("The anwser is: "+ (num1 - num2) );
                        Console.Read();
                        break;

                    case "*":
                        Console.WriteLine("The anwser is: " + (num1 * num2) );
                        Console.Read();
                        break;

                    case "/":
                        Console.WriteLine("The anwser is: "+ (num1 / num2) );
                        Console.Read();
                        break;

                }

            }
            if (choice == 2)
            {
                Console.WriteLine("Enter 1 for Rectangle, 2 for circle and 3 for sphere ");
                int advancedChoice = Convert.ToInt32(Console.ReadLine());

                if (advancedChoice == 1) //rectangle
                {
                    Console.WriteLine("Enter first side ");
                    float rect1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second side ");
                    float rect2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The area of the rectangle is: " + (rect1 * rect2));
                    Console.WriteLine("The circumference of the rectangle is: " + ( (rect1*2) + ( rect2 * 2) ) );
                    Console.Read();
                }

                if (advancedChoice == 2) //circle
                {
                    Console.WriteLine("Enter radius: ");
                    float radius = Convert.ToInt32(Console.ReadLine());
                   
                
                    Console.WriteLine("The area of the circle is: " + ( 0.75 * (3.142 * (radius * radius)) ));
                    Console.WriteLine("The circumference of the circle is: " + ((3.142 * 2) * radius) );
                    Console.Read();
                }

                if (advancedChoice == 3) //sphere
                {
                    Console.WriteLine("Enter radius: ");
                    float radius = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("The volume of the sphere is: " + ( 0.75  * (3.142 *(radius * radius * radius )) ));
                    Console.WriteLine("The circumference of the circle is: " + (3.142 * 4 * (radius * radius)) );
                    Console.Read();
                }
            }

            

        }

    }
}

