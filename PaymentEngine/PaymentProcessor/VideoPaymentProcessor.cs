using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public class VideoPaymentProcessor : PaymentProcessor
    {
        public override bool ProcesPayment()
        {
            AddFreeFirstAid();
            return true;
        }

        private void AddFreeFirstAid()
        {
            // put your logic here
        }
    }
}
