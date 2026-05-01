using System;

namespace DeliverySystemProject.Helpers
{

    public static class ValidationHelper
    {
        // دالة تأكيد أن النص غير فارغ
        public static bool IsValidString(string text)
        {
            
            return !string.IsNullOrWhiteSpace(text);
        }

        // دالة تأكيد أن الوزن أكبر من الصفر
        public static bool IsValidWeight(double weight)
        {
            return weight > 0;
        }
    }
}
