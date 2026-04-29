using System;

namespace DeliverySystemProject.Models
{
     // هون عم نطبق الوراثة من الكلاس الأساسي [cite: 24]
    public class ExpressDelivery : DeliveryOrder
    {
        // الكونسلتركتور بياخد المعلومات وبيرسلها للأب
        public ExpressDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // إعادة تعريف دالة حساب التكلفة 
        public override double CalculateCost()
        {
            // شحن سريع: الوزن مضروب بـ 10 (كمثال بسيط)
            return Weight * 15;
        }

        // إعادة تعريف دالة الوقت 
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 24 Hours.");
        }
    }
}
