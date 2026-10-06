using ass9;
using ass9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal class Standardshipment : Shipman, ITrackable, IInsurable
    {
        Standardshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination) : base(trackingcode, description, weight, delivery, destination)
        {
        }
        public override void printshipman()
        {
            Console.WriteLine(Estimate());
        }
        public override decimal Estimate()
        {
            return del + (Weight * 5);
        }
        public string GetTrackingStatus()
        {
            return $"The shipment {Trackingcode} is ready";

        }
        public decimal CalculateInsurance()
        {
            decimal res = 0.5m * Estimate();
            return res;
        }
        public override Standardshipment deepcopy()
        {
            return new Standardshipment(new string(Trackingcode), new string(descripe), Weight, (int)del, new Delivaryaddress(destination.city, destination.street, destination.buildingnumber));
        }

    }
}