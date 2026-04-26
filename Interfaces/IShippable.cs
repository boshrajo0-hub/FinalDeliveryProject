using System;

namespace DeliverySystemProject.Interfaces
{
    // هاد هو الـ Interface اللي طلبه الدكتور
    public interface IShippable
    {
        // دالة لحساب وقت التوصيل (بدون كود، بس اسم)
        void GetEstimatedTime();
    }
}