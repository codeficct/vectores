using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class IntegerNumbers
    {
        // Property
        const int MAX_LENGTH = 50;
        private int[] numbers;
        private int number;
        // constructor
        public IntegerNumbers()
        {
            number = 0;
            numbers =  new int[MAX_LENGTH];
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
        //public int number { get; set; }

    }
}
