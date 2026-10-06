using ass9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal class DeliveryCenter
    {
        private string? centername;
        private Shipman[]? shipment;
        public DeliveryCenter()
        {
            shipment = new Shipman[20];
        }
        public DeliveryCenter(String centername)
        {
            this.centername = centername;
        }
        public Shipman this[int pos]
        {
            get
            {
                if (pos >= shipment.Length || pos < 0)
                {
                    return default;
                }
                return shipment[pos];

            }
            set
            {
                if (pos >= shipment.Length || pos < 0)
                {
                    Console.WriteLine("nothing");
                }
                else
                {
                    shipment[pos] = value;
                }
            }
        }
        public Shipman this[string track]
        {

            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i].Trackingcode == track)
                    {
                        return shipment[i];
                    }

                }
                return default;

            }

        }
        public bool addshipment(Shipman sh)
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (string.IsNullOrEmpty(shipment[i].Trackingcode))
                {
                    shipment[i] = sh;
                    return true;
                }

            }
            return false;
        }
        public bool removeshipment()
        {
            bool isdeleted = false;
            for (int i = 0; i < shipment.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(shipment[i].Trackingcode))
                {
                    shipment[i] = null;
                    isdeleted = true;
                }
            }
            return isdeleted;

        }
        public void printallshipments()
        {
            foreach (Shipman s in shipment)
            {
                s.printshipman();
            }
        }
        public void printtrackingstatues()
        {
            foreach (ITrackable t in shipment)
            {
                t.GetTrackingStatus();
            }
        }
        public void printinsurance()
        {
            foreach (IInsurable i in shipment)
            {
                i.CalculateInsurance();
            }
        }

    }

}