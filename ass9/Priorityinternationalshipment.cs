using ass9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal class Priortyinternationalshipment : InternationalShipment
    {
        Priortyinternationalshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination, string destinationcountry, decimal customefee) : base(trackingcode, description, weight, delivery, destination, destinationcountry, customefee)
        {
        }
        public sealed override void generatecustomereport()
        {
            base.generatecustomereport();
        }
    }
}