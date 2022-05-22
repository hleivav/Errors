using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class ExtraterrestrialError : NumericInputError
    {
        public ExtraterrestrialError(string v) : base(v)
        {
        }
        public override string UEMessage()
        {
            return "This is not a human error. Is an extraterrestrial error!";
        }
    }
}
