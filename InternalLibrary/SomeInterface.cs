using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalLibrary
{
    internal interface SomeInterface
    {
        decimal CalculateDangerousAmount(decimal partialAmount, decimal otherAmount);
    }
}
