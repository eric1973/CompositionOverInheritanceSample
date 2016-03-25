using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalLibrary
{
    internal interface ISomeInternalInterface
    {
        decimal CalculateDangerousAmount(decimal partialAmount, decimal otherAmount);
    }
}
