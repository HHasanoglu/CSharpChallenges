using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank3Months_Preparation_Kit
{
    public class FlippingBits
    {
        public static void Run() 
        {
            long n = 3;
            var flipBitNumber=FlippBit(n);
            Console.WriteLine(flipBitNumber);
        }

        private static long FlippBit(long n) 
        {
            string binaryValue = Convert.ToString(n, 2).PadLeft(8*sizeof(int),'0') ;
            string flipped = "";
            foreach (char character in binaryValue)
            {
                if (character == '0') flipped += '1';
                else flipped += '0';
            }
            long number = Convert.ToUInt32(flipped, 2);
            return number;
        }
    }
}
