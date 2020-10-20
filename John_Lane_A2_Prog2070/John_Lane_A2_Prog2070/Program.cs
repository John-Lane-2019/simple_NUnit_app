using System;
namespace John_Lane_A2_Prog2070 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //declare variables for console app
            bool isRunning = true;
            
            int a;
            int b;
            int c;

            while (isRunning)
            {
                Console.WriteLine("PRESS 1 TO INPUT TRIANGLE DIMENSIONS");
                Console.WriteLine("PRESS 2 TO EXIT");
                Console.Write("SELECTION: ");

                try
                {
                    //wrap userinput in try-catch block 
                    byte selection = byte.Parse(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            //assign values to variables
                            Console.Write("Enter dimension A: ");
                           
                            a = int.Parse(Console.ReadLine());

                            Console.Write("Enter dimension B: ");

                            b = int.Parse(Console.ReadLine());

                            Console.Write("Enter dimension C: ");

                            c = int.Parse(Console.ReadLine());

                            Console.WriteLine(TriangleSolver.Analyze(a, b, c)); 
                            
                            break;

                        case 2:
                            //exit program
                            isRunning = false;
                            break;
                        default:
                            //default case if user doesn't enter 1 or 2
                            Console.WriteLine("CHOOSE 1 OR 2");
                            break;
                    }
                }
                catch (Exception e)
                {
                   Console.WriteLine(e.Message);
                }
            }
        
        }
    
    }


}