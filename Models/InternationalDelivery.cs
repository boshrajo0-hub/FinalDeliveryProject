using System;

namespace DeliverySystemProject.Models
{
// الوراثة من الكلاس الأساسي
    public class InternationalDelivery : DeliveryOrder
    {
    
        private double _customsTax = 25.0; // ضريبة ثابتة 

        public InternationalDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // حساب التكلفة: وزن * سعر  + ضريبة
        public override double CalculateCost()
        {
            return (Weight * 15) + _customsTax;
        }

        //وقت التوصيل الدولي هو الأطول
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 7 to 14 Business Days.");
        }
    }
}
