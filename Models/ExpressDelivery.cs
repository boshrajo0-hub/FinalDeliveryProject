using System;

namespace DeliverySystemProject.Models
{
     // الوراثة من الكلاس الأساسي 
    public class ExpressDelivery : DeliveryOrder
    {
        
        public ExpressDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // إعادة تعريف دالة حساب التكلفة 
        public override double CalculateCost()
        {
            // شحن سريع: الوزن مضروب ب١٥ 
            return Weight * 15;
        }

        // إعادة تعريف دالة الوقت 
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 24 Hours.");
        }
    }
}
