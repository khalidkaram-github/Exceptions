namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exceptions
            //try
            //{
            //    //int age = -5;
            //    //if (age < 0)
            //    //    throw new Exception("age is negative");


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("run always");
            //}

            #endregion

            var calc = new Calculator();

            try
            {
                int result = calc.Divide(10, 0);
                Console.WriteLine(result);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("age", "Age cannot be negative.");
            }
        }

    }


    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    public class Calculator
    {
        public int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new CustomException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }
    }


}
