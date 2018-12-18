
    using System;

    public class IterativeFibonacci
    {
        public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            
            if (n == 1)
                return 1;
            
            int last = 1;
            int second = 0;
            int sum = 1;

            for (int i = 2; i <= n; i++)
            {
                sum = last + second;

                second = last;
                last = sum;
            }
            
            return sum;
        }

        public static void Main()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("{0} ",Fibonacci(i));
            }
        }
    }
