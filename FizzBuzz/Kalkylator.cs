namespace FizzBuzz
{
    public class Kalkylator
    {
        public static void Main(string[] args)
        {
            //Testa funktioner med olika tal
            for (int i = 1; i <= 30; i++)
            {
                SkrivUtFizzBuzz(i);
            }
        }
        public static string FizzBuzzKalkyl(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }

        }

        public static void SkrivUtFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}