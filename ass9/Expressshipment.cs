using ass9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal class Expressshipment : Shipman
    {
        public static int totalshipmentscreated = 0;
        public void increment()
        {
            totalshipmentscreated++;
        }
        public Expressshipment()
        {

        }
        static Expressshipment()
        {
            Console.WriteLine("Static constructor called");
        }
        public static int GetTotalShipmentsCreated()
        {
            return totalshipmentscreated;
        }
        private decimal extrafee;
        public decimal Extrafee
        {
            get
            {
                return extrafee >= 0 ? del * 0.5m : 0;


            }
        }
        public Expressshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination, decimal extrafee) : base(trackingcode, description, weight, delivery, destination)
        {
            this.extrafee = extrafee;
        }

        public override decimal Estimate()
        {

            return del + (Weight * 5) + Extrafee;

        }
        public override void printshipman()
        {
            Console.WriteLine($"the estimated is:{Estimate}the extrafee is:{extrafee}");
        }
        public decimal CalculateInsurance()
        {
            decimal res = 0.8m * Estimate();
            return res;
        }
        public override Expressshipment deepcopy()
        {
            return new Expressshipment(new string(Trackingcode), new string(descripe), Weight, (int)del, new Delivaryaddress(destination.city, destination.street, destination.buildingnumber), Extrafee);
        }
    }
}