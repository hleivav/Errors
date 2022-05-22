using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class HumorError : TextInputError
    {
        public HumorError(string v) : base(v)
        {
        }
        public override string UEMessage()
        {
            return base.UEMessage() + "You ain't got no humor. This is a terrible error";
        }
    }
}
