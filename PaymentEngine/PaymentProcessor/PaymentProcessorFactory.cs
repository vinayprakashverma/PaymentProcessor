using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor
{
   public  class PaymentProcessorFactory
    {
        public static PaymentProcessor GetPaymentProcessor(PaymentType paymentType)
        {
            PaymentProcessor processor = null;
            switch (paymentType)
            {
                case PaymentType.Book:
                    processor = new BookPaymentProcessor();
                    break;
                case PaymentType.Membership:
                    processor = new MembershipPaymentProcessor();
                    break;
                case PaymentType.PhysicalProduct:
                    processor = new PhysicalProductPaymentProcessor();
                    break;
                case PaymentType.UpgradeMembership:
                    processor = new UpgradeMembershipPaymentProcessor();
                    break;
                case PaymentType.Video:
                    processor = new VideoPaymentProcessor();
                    break;
            }
            return processor;
        }
    }
}
