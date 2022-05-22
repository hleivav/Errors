using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class HumanError : TextInputError
    {
        public HumanError(string v) : base(v)
        {
        }
        public override string UEMessage()
        {
            return "This is a human error. Shit happens";
        }
    }
}
