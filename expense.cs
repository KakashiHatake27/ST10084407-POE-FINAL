using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    internal class expense
    { /* A constructor. */
        public expense()
        {
        }

        /* A constructor that requires values to be passed within it */
        public expense(string name, double value)
        {
            /* Setting the values of the properties to the values passed in. */
            this.name = name;
            this.value = value;
        }

        /* Creating a property for the class. */
        public string name { get; set; }
        public double value { get; set; }
    }
}
