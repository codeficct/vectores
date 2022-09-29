using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Vector
    {
        const int MAX_LENGTH = 50;
        private int[] numbers;
        private int number;
        private int index;

        public Vector()
        {
            number = 0;
            numbers = new int[MAX_LENGTH];
            index = 0;
        }

        public void Set(int value)
        {
            numbers[index] = value;
            index++;
        }

        public void setNumber(int n1, int max, int min)
        {
            int index;
            Random random = new Random();
            number = n1;
            for (index = 1; index <= n1; index++)
            {
                numbers[index] = random.Next(min, max);
            }
        }

        public string getNumber()
        {
            string result = "";
            int index;
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

        public string OrderMethod()
        {
            Array.Sort(numbers);
            return this.getNumber();
        }

        public int countRepeatsElements()
        {
            Array.Sort(numbers);
            int index, count = 0, ele, indexEl = 0;
            for (index = 0; index < number; index++)
            {
                ele = numbers[indexEl];

                if (ele != numbers[index])
                {
                    indexEl = numbers[index];
                    Console.WriteLine(indexEl);
                    count++;
                }
            }
            return count;
        }

        public int countNumElements()
        {
            Array.Sort(numbers);
            int index = 0, count = 0, ele;
            while (index < number)
            {
                ele = numbers[index];
                while ((index < number) && (numbers[index] == ele))
                {
                    index++;
                }
                count++;
            }
            return count;
        }

        public void Purga(ref Vector objResult)
        {
            Array.Sort(numbers);
            int index = 0, count = 0, ele;
            while (index < number)
            {
                ele = numbers[index];
                while ((index < number) && (numbers[index] == ele))
                {
                    index++;
                }
                count++;
                objResult.numbers[count] = ele;
            }
            objResult.number = count;
        }

        public void Frecuence(ref Vector objResult, ref Vector objFrecuence)
        {
            Array.Sort(numbers);
            int index = 0, count = 0, ele, f;
            while (index < number)
            {
                ele = numbers[index]; f = 0;
                while ((index < number) && (numbers[index] == ele))
                {
                    index++; f++;
                }
                count++;
                objResult.numbers[count] = ele;
                objFrecuence.numbers[count] = f;
            }
            objResult.number = count;
            objFrecuence.number = count;
        }
    }
}
