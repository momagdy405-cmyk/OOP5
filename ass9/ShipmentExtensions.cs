using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal static class ShipmentExtensions
    {
       public static string GetSummary(this Shipman shipment)
        {
            return $"Shipment ID: {shipment.Trackingcode}, Destination: {shipment.destination}, Weight: {shipment.Weight} kg";
        }
        public static bool IsDelivered(this Shipman shipment) 
        {
            if (shipment.Trackingcode =="deliverd")
            {
                return true;
            }
            return false;
        }

    }
}
