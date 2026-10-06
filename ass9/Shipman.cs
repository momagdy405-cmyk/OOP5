using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ass9
{
    internal abstract class Shipman
    {
     
        private string trackingcode;
        private string description;
        private int weight;
        private decimal deliveryfee;
        
        public string Trackingcode
        {
            get
            {
                return trackingcode;
            }

        }

        public string descripe
        {
            get
            {
                return description;
            }
            set
            {
                description = string.IsNullOrWhiteSpace(value) ? description : value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value > 0 ? value : weight;
            }
        }
        public decimal del
        {
            get
            {
                return deliveryfee;
            }
            private set
            {
                deliveryfee = value > 0 ? value : deliveryfee;
            }
        }


        public abstract decimal Estimate();

        public Delivaryaddress destination { get; set; }
        
        public Shipman()
        {
            trackingcode = "invalid";
            description = "unknown";
            weight = 1;
            deliveryfee = 50;
        }
        
        public Shipman(string trackingcode)
        {
            this.trackingcode = string.IsNullOrWhiteSpace(trackingcode) ? "invalid" : trackingcode;
            description = "unknown";
            weight = 1;
            deliveryfee = 50;
        }
        public Shipman(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
            this.deliveryfee = delivery;
            this.destination = destination;
        }
        /*
        public Shipman(string trackingcode, string description, int weight)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
        }
        */
        public void updatedeliveryfee(decimal newfee)
        {
            if (newfee > 0)
            {
                deliveryfee += newfee;
            }
        }
        public abstract void printshipman();
        public void updateweight(int newweight)
        {
            if (newweight > 0)
            {
                weight = newweight;
            }
        }
        public void updateweight(int newweight, int extraweight)
        {
            if (newweight > 0 && extraweight >= 0)
            {
                newweight += extraweight;
                weight = newweight;
            }
        } 
        public Shipman copyshipment()
        {
            return (Shipman)this.MemberwiseClone();
        }
        public Shipman shallowcopy()
        {
            return (Shipman)this.MemberwiseClone();
        }
        public abstract Shipman deepcopy();
    }

}