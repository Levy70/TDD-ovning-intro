using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException(int nummer, string exeption)
        {
            // Arrange
            int randomNummer = 4;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            //Assert
            Assert.AreEqual("4", result);

        }
    }
}