using ClassLibrary1;
using System;
using Xunit;

namespace XUnitTestProjectForClassLibrary
{
    public class MyUnitTests
    {
        [Fact]
        public void AddTest1()
        {
            MathClass obj = new MathClass();
            var result = obj.AddNumbers(20, 10);

            Assert.Equal(30, result);
            System.Console.WriteLine("Test Passed with Flying Colors ************************************");
        }

        [Fact]
        public void SubtractTest1()
        {
            MathClass obj = new MathClass();
            var result = obj.SubtractNumbers(25, 10);

            Assert.Equal(15, result);
            System.Console.WriteLine("Test Passed with Flying Colors ************************************");
        }

        [Fact]
        public void AddTest2()
        {
            MathClass obj = new MathClass();
            var result = obj.AddNumbers(20, 10);

            Assert.Equal(30, result);
            System.Console.WriteLine("Test Passed with Flying Colors ************************************");
        }

        [Fact]
        public void SubtractTest2()
        {
            MathClass obj = new MathClass();
            var result = obj.SubtractNumbers(25, 10);

            Assert.Equal(15, result);
            System.Console.WriteLine("Test Passed with Flying Colors ************************************");
        }

    }
}
