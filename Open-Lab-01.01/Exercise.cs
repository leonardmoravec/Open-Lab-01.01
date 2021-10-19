using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int output;
            Int32.TryParse(input, out output);
            if (output < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
