using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Vector
    {
        // Property
        const int MAX_LENGTH = 50;
        private int[] numbers;
        private int number;
        // constructor
        public Vector()
        {
            number = 0;
            numbers = new int[MAX_LENGTH];
        }
        // Methods
        public void setNumber(int n1, int a, int b)
        {
            int index = 0;
            Random random = new Random();
            number = n1;
            for (index = 1; index < n1; index++)
            {
                numbers[index] = random.Next(a, b);
            }
        }
        public string getNumber()
        {
            string result = "";
            int index = 0;
            for (index = 1; index <= number; index++)
            {
                result = result + numbers[index] + "  -  ";
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
    }
}
