using System;

namespace DeliverySystemProject.Models
{
    /// وراثة من الكلاس الأساسي (الأب)
    public class StandardDelivery : DeliveryOrder
    {
    e
        public StandardDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // حساب التكلفة بأسلوب عادي 
        public override double CalculateCost()
        {
            // شحن عادي:الوزن مضروب بـ 5 
            return Weight * 5;
        }

        // وقت التوصيل العادي أطول
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 5 to 7 Business Days.");
        }
    }
}
