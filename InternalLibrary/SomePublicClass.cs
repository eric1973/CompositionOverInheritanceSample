using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalLibrary
{
    // SomeInterface is ether internal but it is legal to implement it because
    // it is an abstraction. Practicining "composition over inheritance" when
    // a base class should not be meant to be public.
    public class SomePublicClass : /*SomeInternalOperations*/ SomeInterface
    {

        public decimal TotalAmount { get; set; }

        // commented base class is internal. no way to do that.
        //public void ExposeCritialCalc(decimal a, decimal b)
        //{
        //    this.TotalAmount = this.CalculateDangerousAmount(a, b);
        //}

        public void Print()
        {
            Console.WriteLine("TotalAmount: '{0}'", TotalAmount);
        }

        // legal to implement interface method and invoke the critial method on
        // a new instance of the internal class 'SomeInternalOperations'.
        public decimal CalculateDangerousAmount(decimal partialAmount, decimal otherAmount)
        {
            SomeInternalOperations internalOp = new SomeInternalOperations();
            this.TotalAmount = internalOp.CalculateDangerousAmount(partialAmount, otherAmount);
            return this.TotalAmount;
        }
    }
}
