namespace ParkingLot
{
    public enum VehicleType
    {
        Car,
        Bike,
        Truck
    }
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }

        public string Ticket { get; set; }
        public DateTime EntryTime { get; set; }

        public string GetAvailableParkingSpot(ParkingSlot parkingSlot)
        {
            string ParkingSpot = string.Empty;
            switch (VehicleType)
            {
                case VehicleType.Car:
                    for (int i = 0; i < parkingSlot.CarSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.CarSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.CarSlots[i, j] == null) // Check if the spot is available
                            {
                                
                                EntryTime = DateTime.Now;
                                GenerateTicket();
                                parkingSlot.CarSlots[i, j] = this; // Mark the spot as occupied
                                ParkingSpot = $"Car Parking Spot at Row {i} and Column {j} and Ticket Number: {Ticket}";
                                return ParkingSpot;
                            }
                        }
                    }
                    break;
                case VehicleType.Bike:
                    for (int i = 0; i < parkingSlot.BikeSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.BikeSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.BikeSlots[i, j] == null) // Check if the spot is available
                            {
                                
                                EntryTime = DateTime.Now;
                                GenerateTicket();
                                parkingSlot.BikeSlots[i, j] = this; // Mark the spot as occupied
                                ParkingSpot = $"Bike Parking Spot at Row {i} and Column {j} and Ticket Number: {Ticket}";
                                return ParkingSpot;
                            }
                        }
                    }
                    break;
                case VehicleType.Truck:
                    for (int i = 0; i < parkingSlot.TruckSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.TruckSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.TruckSlots[i, j] == null) // Check if the spot is available
                            {
                                
                                EntryTime = DateTime.Now;
                                GenerateTicket();
                                parkingSlot.TruckSlots[i, j] = this; // Mark the spot as occupied
                                ParkingSpot = $"Truck Parking Spot at Row {i} and Column {j} and Ticket Number: {Ticket}";
                                return ParkingSpot;
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Vehicle Type");
                    break;
            }
            return "No Parking Spot Available";
        }

        public void GenerateTicket()
        {
            Ticket = Random.Shared.Next(1000, 9999).ToString(); // Generate a random 4-digit ticket number
        }

        
    }
}