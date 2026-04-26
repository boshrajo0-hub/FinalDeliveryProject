using System;
using DeliverySystemProject.Interfaces;

namespace DeliverySystemProject.Models
{
    public abstract class DeliveryOrder : IShippable
    {
        // 1. الحقول الخاصة
        private string _trackingNumber;
        private string _senderName;
        private string _recipientName;
        private string _destination;
        private double _weight;

        // 2. الخصائص
        public string TrackingNumber { get { return _trackingNumber; } }

        public string SenderName
        {
            get { return _senderName; }
            set { _senderName = value; }
        }

        public string RecipientName
        {
            get { return _recipientName; }
            set { _recipientName = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        // 3. الأحداث والتفويض
        public delegate void StatusChangedHandler(string message);
        public event StatusChangedHandler OnStatusChanged;

        public void UpdateStatus(string newStatus)
        {
            if (OnStatusChanged != null)
            {
                OnStatusChanged($"Notification: Order {TrackingNumber} is now: {newStatus}");
            }
        }

        // 4. الباني (Constructor)
        protected DeliveryOrder(string trackingNumber, string sender, string recipient)
        {
            _trackingNumber = trackingNumber;
            _senderName = sender;
            _recipientName = recipient;
        }

        // 5. الدوال المجردة
        public abstract double CalculateCost();
        public abstract void GetEstimatedTime();
    }
}