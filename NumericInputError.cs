using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class NumericInputError : UserError
    {
        private string v;

        public NumericInputError(string v)
        {
            this.v = v;
        }

        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!"; 
        }
    }
}
