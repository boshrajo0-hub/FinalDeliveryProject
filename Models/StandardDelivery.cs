using System;

namespace DeliverySystemProject.Models
{
    // هون كمان وراثة من الكلاس الأساسي (الأب)
    public class StandardDelivery : DeliveryOrder
    {
        // الكونسلتركتور بيمرر البيانات للأب (base)
        public StandardDelivery(string trackingNumber, string sender, string recipient)
            : base(trackingNumber, sender, recipient)
        {
        }

        // هون بنحسب التكلفة بأسلوب "عادي" (أرخص من السريع)
        public override double CalculateCost()
        {
            // شحن عادي: الوزن مضروب بـ 5 (أرخص بمرتين)
            return Weight * 5;
        }

        // وقت التوصيل العادي أكيد أطول
        public override void GetEstimatedTime()
        {
            Console.WriteLine("Estimated Delivery Time: 3 to 5 Business Days.");
        }
    }
}