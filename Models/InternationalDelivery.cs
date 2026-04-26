using System;

namespace DeliverySystemProject.Models
{
    // الوراثة من الكلاس الأساسي للمرة الثالثة
    public class InternationalDelivery : DeliveryOrder
    {
        // حقل إضافي خاص بالشحن الدولي فقط
        private double _customsTax = 25.0; // ضريبة ثابتة مثلاً

        public InternationalDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // حساب التكلفة: وزن * سعر مرتفع + ضريبة
        public override double CalculateCost()
        {
            return (Weight * 15) + _customsTax;
        }

        // وقت التوصيل الدولي هو الأطول طبعاً
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 7 to 14 Business Days.");
        }
    }
}