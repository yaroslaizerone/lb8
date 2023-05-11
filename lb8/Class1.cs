using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class Task1
    {
        public int function(int x)
        {
            if (x > 0)
            {
                return 2 * x - 10;
            }
            if (x < 0)
            {
                return 2 * Math.Abs(x) - 1;
            }
            return 0;
        }

        public (int, int) change(int a, int b)
        {
            (a, b) = (b, a);
            return (a, b);
        }
    }

    public class Task2
    {
        public int theLargest(int a, int b, int c)
        {
            int result = a;
            if (b > result) result = b;
            if (c > result) result = c;
            return result;
        }

        public (int, int) sumAndProiz(int a)
        {
            int sum = 0, proiz = 1;
            while (a > 0)
            {
                sum += a % 10;
                proiz *= a % 10;
                a = a / 10;
            }
            return (sum, proiz);
        }
    }

    public class Task3
    {
        public int factorial(int a)
        {
            if (a == 1) return 1;
            return a * factorial(a - 1);
        }

        public int largestNumber(int a)
        {
            int max = a % 10;
            a = a / 10;
            while (a > 0)
            {
                if (max < a % 10)
                {
                    max = a % 10;
                }
                a = a / 10;
            }
            return max;
        }
    }
}
