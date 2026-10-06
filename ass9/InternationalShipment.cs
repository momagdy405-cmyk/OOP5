using ass9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal class InternationalShipment : Shipman, ITrackable, IInsurable
    {

        private string destinationCountry;
        private decimal customsfee;
        public string DestinationCountry
        {
            get
            {
                if (string.IsNullOrEmpty(destinationCountry) || string.IsNullOrWhiteSpace(destinationCountry))
                {
                    return "Unknown";
                }
                return destinationCountry;
            }
        }
        public decimal Customsfee
        {
            get { return customsfee >= 0 ? customsfee : 0; }
        }
        public override decimal Estimate()
        {
            return del + (Weight * 5) + Customsfee;
        }
        public InternationalShipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination, string destinationcountry, decimal customfee) : base(trackingcode, description, weight, delivery, destination)
        {
            this.destinationCountry = destinationcountry;
            this.customsfee = customfee;
        }
        public override void printshipman()
        {

            Console.WriteLine($"the destinationcountry is:{destinationCountry}the customefee is:{customsfee}the estimated is:{Estimate}");

        }
        public virtual void generatecustomereport()
        {

        }
        public string GetTrackingStatus()
        {
            return $"The shipment {Trackingcode} is ready";

        }
        public decimal CalculateInsurance()
        {
            decimal res = 0.12m * Estimate();
            return res;
        }
        public override InternationalShipment deepcopy()
        {
            return new InternationalShipment(new string(Trackingcode), new string(descripe), Weight, (int)del, new Delivaryaddress(destination.city, destination.street, destination.buildingnumber),"egy",90);
        }

    }

}