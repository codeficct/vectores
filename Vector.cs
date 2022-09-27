using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Vector
    {
        private int[] numbers;
        private int number;

        public Vector()
        {
            number = 0;
            numbers = new int[number];
        }

        public void setNumber(int n1, int max, int min)
        {
            int index;
            numbers = new int[n1];
            Random random = new Random();
            number = n1;
            for (index = 0; index < n1; index++)
            {
                numbers[index] = random.Next(min, max);
            }
        }

        public string getNumber()
        {
            string result = "";
            int index;
            for (index = 0; index < number; index++)
            {
                if (index == number - 1) result = result + numbers[index];
                else result = result + numbers[index] + "  -  ";
            }
            return result;
        }

        public int Sum()
        {
            int index, result = 0;
            for (index = 0; index < number; index++)
            {
                result = result + numbers[index];
            }
            return result;
        }

        public double Half()
        {
            return Sum() / (double)number;
        }

        public double Promhalf()
        {
            double f = 0, p = Half();
            int index;
            for (index = 0; index < number; index++)
            {
                f = f + Math.Abs(p - numbers[index]);
            }
            return f / number;
        }

        public int CountPrime()
        {
            int count = 0, index;
            IntegerNumber objNumber = new IntegerNumber();
            for (index = 1; index < number; index++)
            {
                objNumber.setNumber(numbers[index]);
                if (objNumber.isPrime()) count++;
            }
            return count;
        }

        public int getMaxMin(bool max)
        {
            int index, major = numbers[1];
            for (index = 2; index < number; index++)
            {
                bool filter = max ? numbers[index] > major : numbers[index] < major;
                if (filter) major = numbers[index];
            }
            return major;
        }

        public void SelectPrimes(ref Vector objResult)
        {
            int index;
            IntegerNumber objNumber = new IntegerNumber();
            objResult.number = 0;
            for (index = 1; index < number; index++)
            {
                objNumber.setNumber(numbers[index]);
                if (objNumber.isPrime())
                {
                    objResult.number++;
                    objResult.numbers[objResult.number] = numbers[index];
                }
            }
        }

        // Segmentar en primos y no primos ordenados
        // Recordando: Ordenamiento por intercambio.
        public void SegmentarElementos(ref Vector objVectorResult)
        {
            IntegerNumber objInteger = new IntegerNumber();
            int[] v = { 6, 7, 5, 8, 4, 6, 2 };
            int[] prime = new int[number];
            int[] noPrime = new int[number];
            int index, a = 0, b = 0;
            objVectorResult.number = number;
            for (index = 0; index < number; index++)
            {
                objInteger.setNumber(numbers[index]);
                if (objInteger.isPrime())
                {
                    Console.WriteLine("is Prime " + numbers[index]);
                    prime[a] = numbers[index];
                    a++;
                }
                else
                {
                    Console.WriteLine("is not Prime " + numbers[index]);
                    noPrime[b] = numbers[index];
                    b++;
                }
            }
            var z = new int[prime.Length + noPrime.Length];
            prime.CopyTo(z, 0);
            noPrime.CopyTo(z, prime.Length);
            objVectorResult.numbers = z;
        }
    }
}
