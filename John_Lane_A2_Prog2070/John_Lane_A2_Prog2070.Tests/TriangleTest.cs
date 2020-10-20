using NUnit.Framework;
using System.Text;

namespace John_Lane_A2_Prog2070.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        /// <summary>
        /// these inputs are for an equilateral
        /// if they don't work then there's something wrong
        /// with the validation logic
        /// </summary>
        [Test]
        public void Analyze_Is_An_EquilateralTriangle()
        {
            string result = TriangleSolver.Analyze(3, 3, 3);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("THESE DIMENSIONS FORM A TRIANGLE");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("THIS IS AN EQUILATERAL TRIANGLE");

            Assert.AreEqual(result, stringBuilder.ToString());
        }
        /// <summary>
        /// these inputs are for a scalene
        /// if they don't work then there's something wrong
        /// with the validation logic
        /// </summary>
        [Test]
        public void Analyze_Is_A_ScaleneTriangle()
        {
            string result = TriangleSolver.Analyze(3, 4, 6);

            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.AppendLine("THESE DIMENSIONS FORM A TRIANGLE");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("THIS IS A SCALENE TRIANGLE");

            Assert.AreEqual(result,stringBuilder.ToString());
            
        }
        /// <summary>
        /// these inputs are for an isosceles
        /// if they don't work then there's something wrong
        /// with the validation logic
        /// </summary>
        [Test]
        public void Analyze_Is_An_IsoscelesTriangle() 
        {
            string result = TriangleSolver.Analyze(2, 2, 3);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("THESE DIMENSIONS FORM A TRIANGLE");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("THIS IS AN ISOCELES TRIANGLE");

            Assert.AreEqual(result, stringBuilder.ToString());

        }

        /// <summary>
        /// these inputs violate the rules of forming a triangle
        /// if they don't work then there's something wrong
        /// with the validation logic
        /// </summary>
        [Test]
        public void Analyze_Is_Not_A_Triangle()
        {
            string result = TriangleSolver.Analyze(2, 2, 5);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("THESE SIDES CAN'T FORM A TRIANGLE");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");

            Assert.AreEqual(result, stringBuilder.ToString());

        }
        /// <summary>
        /// if the static method works correctly it should not
        /// return an empty string
        /// </summary>
        [Test]
        public void Analyze_Does_Not_Return_Empty_String() 
        {
            string result = string.Empty;

            Assert.AreNotEqual(result, TriangleSolver.Analyze(2, 2, 2));
        }
        /// <summary>
        /// if the static method works correcty it should
        /// not return as null or white space
        /// </summary>
        [Test]
        public void Analyze_Does_Not_Return_NullOrWhiteSpace() 
        {
            bool result = string.IsNullOrWhiteSpace(TriangleSolver.Analyze(2, 2, 2));

            Assert.IsFalse(result);
        }

    }
}