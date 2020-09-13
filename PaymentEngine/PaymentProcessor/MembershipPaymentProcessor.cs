using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public class MembershipPaymentProcessor : PaymentProcessor
    {
        public override bool ProcesPayment()
        {
            ActivateMembership();
            return true;
        }

        private void ActivateMembership()
        {
            // put logic here to Activate Member ship
            EmalHandler.SendActivateMembershipEmail();
        }
    }
}
