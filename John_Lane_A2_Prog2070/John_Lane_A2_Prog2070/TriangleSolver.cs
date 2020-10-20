using System.Text;

namespace John_Lane_A2_Prog2070
{
    public static class TriangleSolver
    {
        static TriangleSolver()
        {

        }
        //static method taking user inputs as arguments with input validations
        public static string Analyze(int a, int b, int c)
        {
            string returnMessage1, returnMessage2 = "";

            if (a + b > c && a + c > b && b + c > a)
            {
                returnMessage1 = "THESE DIMENSIONS FORM A TRIANGLE";

                if (a == b && b == c)
                {
                    returnMessage2 = "THIS IS AN EQUILATERAL TRIANGLE";
                }
                else if (a == b || a == c || b == c)
                {
                    returnMessage2 = "THIS IS AN ISOCELES TRIANGLE";
                }
                else
                {
                    returnMessage2 = "THIS IS A SCALENE TRIANGLE";
                }
            }
            else
            {
                returnMessage1 = "THESE SIDES CAN'T FORM A TRIANGLE";
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(returnMessage1);
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine(returnMessage2);

            return stringBuilder.ToString();

        }
    }
}
