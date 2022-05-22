using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class TextInputError : UserError
    {
        private string v;

        public TextInputError(string v)
        {
            this.v = v;
        }

        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
