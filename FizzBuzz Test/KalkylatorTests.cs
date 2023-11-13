using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]

        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        {
            // Arrange
            int randomNummer = 1;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            //Assert
            Assert.AreEqual("1", result);

        }
    }
}