using PaymentProcessor;
using System;

namespace PaymentEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter payment type: ");
            var paymentTypeInput = Console.ReadLine();
            PaymentType paymentType = (PaymentType)Enum.Parse(typeof(PaymentType), paymentTypeInput);
            var paymentProcessor = PaymentProcessorFactory.GetPaymentProcessor(paymentType);
            var result = paymentProcessor.ProcesPayment();
        }
    }
}
