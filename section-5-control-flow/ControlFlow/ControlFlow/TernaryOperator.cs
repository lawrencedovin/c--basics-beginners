using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class TernaryOperator
    {
        public static float checkPrice(bool isGoldCustomer)
        {
            return (isGoldCustomer) ? 19.95f : 29.95f;
        }
    }
}
