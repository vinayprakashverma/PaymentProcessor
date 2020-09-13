using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public class PhysicalProductPaymentProcessor : PaymentProcessor
    {
        public override bool ProcesPayment()
        {
            GeneratePackingSlip();
            return true;
        }
        private void GeneratePackingSlip()
        {
            // put logic here to generate packing slip
        }
    }
}
