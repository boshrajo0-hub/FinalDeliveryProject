using System;

namespace DeliverySystemProject.Helpers
{
    // لاحظي كلمة static.. معناها هاد الكلاس "جاهز للاستخدام" فوراً
    public static class ValidationHelper
    {
        // دالة بتتأكد إنو النص مو فاضي (مثلاً رقم التتبع أو العنوان)
        public static bool IsValidString(string text)
        {
            // بترجع true إذا كان النص فيه قيمة، و false إذا كان فاضي
            return !string.IsNullOrWhiteSpace(text);
        }

        // دالة بتتأكد إنو الوزن مو صفر أو رقم سالب
        public static bool IsValidWeight(double weight)
        {
            return weight > 0;
        }
    }
}