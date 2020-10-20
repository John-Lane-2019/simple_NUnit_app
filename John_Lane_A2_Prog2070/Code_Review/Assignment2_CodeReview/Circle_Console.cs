using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
//Style: unused using statements should be removed. 
namespace RGBAssignment1
{
    //Purpose: the purpose of this application is to take and validate user inputs to return circle properties to the console.
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            int radius = 0; /* Implementation: there's no need to set a default value of zero  since 
                            the Circle class's constructor should not accept this value since you cannot have a radius of zero.*/
                            
            int menuOption = 0; //Implementation: control your loop with a boolean.

            radius = GetRadiusFromUserInput(radius);

            do 
            {
                do
                {
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();

                    try
                    {
                        menuOption = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Wrong option, please select from the menu:");
                        Console.WriteLine();
                    }


                } while (menuOption == 0 || menuOption < 0 || menuOption > 5);/*Implementation/Legibility: a while loop controlled by a 
                by single boolean would increase legibility and ensure that no execution occurs prior to testing the condition's 
                validity. Boolean can be set to false by switch case within loop that will exit the program. Invalid inputs can
                be handled by default case.*/

                switch (menuOption)
                {
                    case 1:
                        radius = circle.GetRadius();
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 2:

                        radius = GetRadiusFromUserInput(radius);
                        circle.SetRadius(radius);
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + Math.Round(circle.GetCircumference(), 2));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("The Area of the circle is: " + Math.Round(circle.GetArea(), 2));
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0); //Implementation: can just use default case to exit.
                                             //Maintainability: magic numbers are not good for anyone who has to maintain your code.
                        break;
                    default:
                        break;
                }

            } while (menuOption > 0 || menuOption < 5); //Implementation: see previous remark about while loops and switch case.
        }

        /*Implementation: This doesn't need to be a method. Just set the program to get it from the user by default when the 
         program starts by putting the retrieval of the radius variable in a separate loop that doesn't stop
         executing until an acceptable value has been given. This value can then be passed to the Circle class's
         constructor.*/
        private static int GetRadiusFromUserInput(int radius)
        {
            do
            {
                Console.WriteLine("Please enter radius value: ");
                Console.WriteLine();

                try
                {
                    radius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Not the correct format, please insert a int greater than zero!");
                    Console.WriteLine();
                }

            } while (radius == 0);
            return radius;
        }


    }

}
