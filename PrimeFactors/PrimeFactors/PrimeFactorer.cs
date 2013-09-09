using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactorer
    {
        public static List<int> Factorize(int number)
        {
            var result = new List<int>();

            int i;
            for (i = 2; number > 1; i++)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                        result.Add(i);
                        number /= i;
                    }
                }
            }

            return result;
        }
    }
}