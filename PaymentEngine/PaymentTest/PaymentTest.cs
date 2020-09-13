using NUnit.Framework;
using PaymentProcessor;

namespace Tests
{
    public class PaymentTest
    {
        
        [Test]
        public void BookPayment()
        {

            var processor = PaymentProcessorFactory.GetPaymentProcessor(PaymentType.Book);
            var result = processor.ProcesPayment();
            Assert.AreEqual(result, true);
        }

        [Test]
        public void MembershipPayment()
        {

            var processor = PaymentProcessorFactory.GetPaymentProcessor(PaymentType.Membership);
            var result = processor.ProcesPayment();
            Assert.AreEqual(result, true);
        }

        [Test]
        public void PhysicalProductPayment()
        {

            var processor = PaymentProcessorFactory.GetPaymentProcessor(PaymentType.PhysicalProduct);
            var result = processor.ProcesPayment();
            Assert.AreEqual(result, true);
        }

        [Test]
        public void UpgradeMembershipPayment()
        {

            var processor = PaymentProcessorFactory.GetPaymentProcessor(PaymentType.UpgradeMembership);
            var result = processor.ProcesPayment();
            Assert.AreEqual(result, true);
        }

        [Test]
        public void VideoPayment()
        {

            var processor = PaymentProcessorFactory.GetPaymentProcessor(PaymentType.Video);
            var result = processor.ProcesPayment();
            Assert.AreEqual(result, true);
        }
    }
}