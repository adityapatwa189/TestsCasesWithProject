namespace PractiseTests
{
    public class SumOfDigits
    {
        public int DigitSum(int number)
        {
            if (number == 0)
            return 0;

            if (number % 9 == 0)
            return 9;
            
            else
            return number % 9;
        }
    }
}
