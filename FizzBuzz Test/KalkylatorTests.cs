using FizzBuzz;

namespace FizzBuzz_Test
{
    

    [TestClass]
    
    public class KalkylatorTests
    {
        [TestMethod]
        
        public void FizzBuzz_ReturnerarNummer_NärDetInteÄrDelbartMed3Eller5()
        {
            // Arrange
            int number = 2;

            // Act
            string resultat = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.AreEqual("2", resultat);

        }
        [TestMethod]
        public void FizzBuzz_ReturneraFizz_NärDetÄrDelbartMed3()
        {
            //Arrange
            int number = 9;

            //Act
            string resultat = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.AreEqual("Fizz", resultat);
        }
        [TestMethod]
        public void FizzBuzz_RetunerarFizzBuzz_NärDetÄrDelbartMed3Och5()
        {
            //Arrang
            int number = 15;

            //Act
            string resultat = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.AreEqual("FizzBuzz", resultat);
        }
    }
}