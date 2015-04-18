using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalLibrary
{
    internal class SomeInternalOperations : SomeInterface
    {
        public decimal CalculateDangerousAmount(decimal partialAmount, decimal otherAmount)
        {
            return partialAmount + otherAmount;
        }
    }
}
