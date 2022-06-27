using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    /* Creating a class that implements the IComparer interface. */
    internal class SortExpenses : IComparer<expense>
    {

        /// If the value of the first expense is greater than the value of the second expense, return 1.
        /// If the value of the first expense is less than the value of the second expense, return -1. If
        /// the value of the first expense is equal to the value of the second expense, return 0
        public int Compare(expense x, expense y)
        {
            if (x.value > y.value)
            {
                return 1;
            }
            else if (x.value < y.value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
