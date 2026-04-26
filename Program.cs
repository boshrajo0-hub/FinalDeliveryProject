using System;
using DeliverySystemProject.Models;
using DeliverySystemProject.Helpers;

namespace DeliverySystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create Express Delivery
            ExpressDelivery myExpress = new ExpressDelivery("BOSHRA-2026", "Boshra", "Ahmad");

            // 2. Subscribe to Event (Displaying updates)
            myExpress.OnStatusChanged += (msg) => Console.WriteLine(msg);

            // 3. Validation
            double testWeight = 15.5;
            if (ValidationHelper.IsValidWeight(testWeight))
            {
                myExpress.Weight = testWeight;
            }
            myExpress.Destination = "Damascus, Syria";

            // 4. Show Details
            Console.WriteLine("======= BOSHRA DELIVERY SYSTEM =======");
            Console.WriteLine($"Tracking: {myExpress.TrackingNumber}");
            Console.WriteLine($"Sender: {myExpress.SenderName} | Receiver: {myExpress.RecipientName}");
            Console.WriteLine($"Weight: {myExpress.Weight} KG");
            Console.WriteLine($"Total Cost: {myExpress.CalculateCost()} SYP");
            myExpress.GetEstimatedTime();

            Console.WriteLine("\n======= STATUS UPDATES =======");
            myExpress.UpdateStatus("Order Picked Up");
            myExpress.UpdateStatus("In Transit to " + myExpress.Destination);
            myExpress.UpdateStatus("Delivered Successfully");

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("All OOP Requirements Met Successfully!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}