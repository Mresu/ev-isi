using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class NotAvailableEXception:Exception
    {
        public NotAvailableEXception(string massage):base(massage) { }
    }
}
