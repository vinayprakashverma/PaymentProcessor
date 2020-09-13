using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
    public class UpgradeMembershipPaymentProcessor : PaymentProcessor
    {
        public override bool ProcesPayment()
        {
            UpgradeMembership();
            return true;
        }

        private void UpgradeMembership()
        {
            // put logic here to Upgrade Member ship
            EmalHandler.SendUpgradeMembershipEmail();
        }
    }
}
