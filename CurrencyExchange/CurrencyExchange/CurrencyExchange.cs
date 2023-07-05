using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    // *****************************************
    // DON"T CHANGE CLASS NAME OR FUNCTION NAME
    // *****************************************
    public static class CurrencyExchange
    {
        //Your Code is Here:
        //==================
        /// <summary>
        /// find the index of the USD Dollar $ with the smallest number of questions.
        /// </summary>
        /// <param name="N">Number of customers (N)</param>
        /// <param name="M">Number of currencies (M)</param>
        /// <param name="knows">N*M Matrix indicating whether customer i knows currency j or not</param>
        /// <returns>index of US Dollar</returns>
        public static int CheckUSD(int N, int M, bool[,] knows)
        {

            //knows[P,C]=true if person P knows currency C and knows[P,C]=false if person P doesn't know Currency C.
            //


            int x = 0;
            bool pol = true;
            int count1 = 0;
            int count2 = 0;
            while (pol)
            {
                if (knows[count2, count1])
                {
                    count2++;
                    if (count2 == N)
                    {
                        x = count1;
                        pol = false;

                    }
                }
                else
                {
                    count1++;
                }

            }




            return x;
        }
    }
}
