using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public class BookPaymentProcessor : PaymentProcessor
    {
        public override bool ProcesPayment()
        {
            CeateDuplicatePackingSlip();
            return true;
        }
        private void CeateDuplicatePackingSlip()
        {
            // put logic here to Ceate Duplicate Packing Slip
        }
    }
}
