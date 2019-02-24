namespace HelloMethodOverloading
{
    class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}