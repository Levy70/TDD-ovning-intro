using FizzBuzz;

namespace FizzBuzz_Test
{
    [DataRow(3, "Fizz")]
    [DataRow(5, "Buzz")]
    [DataRow(15, "FizzBuzz")]

    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]

        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException(int number, string expectedResult)
        {
            // Arrange

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(number);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}