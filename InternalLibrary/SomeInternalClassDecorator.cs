using System;

namespace InternalLibrary
{
    // ISomeInternalInterface is internal but it is legal to implement it because
    // it is an abstraction. Practicing "composition over inheritance" when
    // a base class is not meant to be public.
    public class SomeInternalClassDecorator : /*SomeInternalOperations*/ ISomeInternalInterface
    {
        private readonly SomeInternalOperations _internalOp;

        public decimal TotalAmount { get; set; }

        public SomeInternalClassDecorator()
        {
            _internalOp = new SomeInternalOperations();
        }

        // legal to implement the internal interface method and invoke the critial method on
        // a new instance of the internal class 'SomeInternalOperations'.
        public decimal CalculateDangerousAmount(decimal partialAmount, decimal otherAmount)
        {
            TotalAmount = _internalOp.CalculateDangerousAmount(partialAmount, otherAmount);
            return TotalAmount;
        }

        // commented base class is internal. no way to do that.
        //public void ExposeBaseClassCritialCalc(decimal a, decimal b)
        //{
        //    this.TotalAmount = this.CalculateDangerousAmount(a, b);
        //}

        public void Print()
        {
            Console.WriteLine("TotalAmount: '{0}'", TotalAmount);
        }
    }
}