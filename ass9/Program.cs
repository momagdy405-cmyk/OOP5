namespace ass9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipman shipment1 = new Expressshipment("123", "Electronics", 5, 10, new Delivaryaddress("123 Main St", "Cityville", 12345),190);
            Shipman shipment2 = shipment1;
            Shipman shipment3 = shipment1.shallowcopy();
            shipment3.destination.city = "newyork";
            Console.WriteLine(shipment1.destination.city);
            Shipman s=new Expressshipment("123", "Electronics", 5, 10, new Delivaryaddress("123 Main St", "Cityville", 12345), 190);
            Shipman s1 = s.deepcopy();
            s1.destination.city = "giza";
            Console.WriteLine(s.destination.city);
            Expressshipment ship = new Expressshipment();
            Expressshipment ship1 = new Expressshipment();
            ship.increment();
            ship1.increment();
            Console.WriteLine(Expressshipment.totalshipmentscreated);
           Console.WriteLine ($"the totalshipmentscreatedis:{ Expressshipment.GetTotalShipmentsCreated()}");
            DeliveryUtilities.PrintSystemTitle();
           Console.WriteLine( ShipmentExtensions.GetSummary(shipment1));
           Console.WriteLine( ShipmentExtensions.IsDelivered(ship));
            




        }
    }
}
