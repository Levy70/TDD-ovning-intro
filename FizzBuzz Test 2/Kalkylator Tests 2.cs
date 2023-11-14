using FizzBuzz;

namespace FizzBuzz_Test_2
{
    [TestClass]
    public class KalkylatorTests2
    {
        [TestMethod]
        public void TestFizz()
        {
            //Arrange
            int number = 9; //Ett tal som är delbart med 3

            //Act
            string expected = "Fizz";
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Kalkylator.SkrivUtFizzBuzz(number);
            string resultat = stringWriter.ToString().Trim();

            //Assert
            Assert.AreEqual(expected, resultat);
        }

        [TestMethod]
        public void TestBuzz()
        {
            //Arrange
            int number = 10; //Ett tal som är delbart med 5

            //Act
            string expected = "Buzz";
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Kalkylator.SkrivUtFizzBuzz(number);
            string resultat = stringWriter.ToString().Trim();

            //Assert
            Assert.AreEqual(expected, resultat);
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            int number = 15; //Ett tal som är delbart med både 3 och 5

            //Act
            string expected = "FizzBuzz";
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Kalkylator.SkrivUtFizzBuzz(number);
            string resultat = stringWriter.ToString().Trim();

            //Assert
            Assert.AreEqual(expected, resultat);
        }
    }
}