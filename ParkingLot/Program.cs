using System;

namespace ParkingLot
{
    class Program
    {
        public void RemoveVehicle(ParkingSlot parkingSlot, string ticket, VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    for (int i = 0; i < parkingSlot.CarSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.CarSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.CarSlots[i, j] != null && parkingSlot.CarSlots[i, j].Ticket == ticket) // Check if the spot is occupied by the vehicle with the given ticket
                            {
                                parkingSlot.CarSlots[i, j] = null; // Mark the spot as available
                                Console.WriteLine($"Vehicle with Ticket Number: {ticket} has been removed from Car Parking Spot at Row {i} and Column {j}");
                                return;
                            }
                        }
                    }
                    break;
                case VehicleType.Bike:
                    for (int i = 0; i < parkingSlot.BikeSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.BikeSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.BikeSlots[i, j] != null && parkingSlot.BikeSlots[i, j].Ticket == ticket) // Check if the spot is occupied by the vehicle with the given ticket
                            {
                                parkingSlot.BikeSlots[i, j] = null; // Mark the spot as available
                                Console.WriteLine($"Vehicle with Ticket Number: {ticket} has been removed from Bike Parking Spot at Row {i} and Column {j}");
                                return;
                            }
                        }
                    }
                    break;
                case VehicleType.Truck:
                    for (int i = 0; i < parkingSlot.TruckSlots.GetLength(0); i++)
                    {
                        for (int j = 0; j < parkingSlot.TruckSlots.GetLength(1); j++)
                        {
                            if (parkingSlot.TruckSlots[i, j] != null && parkingSlot.TruckSlots[i, j].Ticket == ticket) // Check if the spot is occupied by the vehicle with the given ticket
                            {
                                parkingSlot.TruckSlots[i, j] = null; // Mark the spot as available
                                Console.WriteLine($"Vehicle with Ticket Number: {ticket} has been removed from Truck Parking Spot at Row {i} and Column {j}");
                                return;
                            }
                        }
                    }
                    break;
            }
        }

        public void CalulateParkingFee(DateTime entryTime, DateTime exitTime, VehicleType vehicleType)
        {
            TimeSpan parkingDuration = exitTime - entryTime;
            int hoursParked = (int)Math.Ceiling(parkingDuration.TotalHours);
            int fee = 0;

            switch (vehicleType)
            {
                case VehicleType.Car:
                    fee = hoursParked * 20;
                    break; // Assuming $20 per hour for cars
                case VehicleType.Bike:
                    fee = hoursParked * 10; // Assuming $10 per hour for bikes
                    break;
                case VehicleType.Truck:
                    fee = hoursParked * 30; // Assuming $30 per hour for trucks
                    break;
                default:
                    throw new ArgumentException("Invalid Vehicle Type");
            }
            Console.WriteLine($"Parking Fee for Vehicle is ${fee}");
            
        }


        Vehicle FindVehicleByTicket(Vehicle[,] parkingSlots, string ticketNumber, VehicleType vehicleType)
        {
            for (int i = 0; i < parkingSlots.GetLength(0); i++)
            {
                for (int j = 0; j < parkingSlots.GetLength(1); j++)
                {
                    if (parkingSlots[i, j] != null && parkingSlots[i, j].Ticket == ticketNumber)
                    {
                        return parkingSlots[i, j];
                    }
                }
            }
            return null;
        }

        public static void Main()
        {
            ParkingSlot parkingSlot = new ParkingSlot();
            Program program = new Program();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Parking Lot System!");

            while (true)
            {
                Console.WriteLine("1. Park a Vehicle | 2. Remove a Vehicle | 3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Vehicle Number: ");
                        string vehicleNumber = Console.ReadLine();

                        Console.WriteLine("Enter Vehicle Type (1 for Car, 2 for Bike, 3 for Truck):");
                        Vehicle vehicle = new Vehicle();

                        break;
                    case 2:
                        Console.WriteLine("Enter Ticket Number: ");
                        string ticketNumber = Console.ReadLine();

                        Console.WriteLine("Enter Vehicle Type (1 for Car, 2 for Bike, 3 for Truck):");
                        VehicleType vehicleType = (VehicleType)int.Parse(Console.ReadLine());

                        Vehicle vehicleToRemove = null;

                        switch (vehicleType)
                        {
                            case VehicleType.Car:
                                vehicleToRemove = program.FindVehicleByTicket(
                                    parkingSlot.CarSlots,
                                    ticketNumber,
                                    VehicleType.Car);
                                break;

                            case VehicleType.Bike:
                                vehicleToRemove = program.FindVehicleByTicket(
                                    parkingSlot.BikeSlots,
                                    ticketNumber,
                                    VehicleType.Bike);
                                break;

                            case VehicleType.Truck:
                                vehicleToRemove = program.FindVehicleByTicket(
                                    parkingSlot.TruckSlots,
                                    ticketNumber,
                                    VehicleType.Truck);
                                break;

                            default:
                                Console.WriteLine("Invalid Vehicle Type");
                                continue;
                        }
                        if (vehicleToRemove == null)
                        {
                            Console.WriteLine("Vehicle with the given ticket number not found.");
                            break;
                        }

                        program.CalulateParkingFee(vehicleToRemove.EntryTime, DateTime.Now, vehicleType);
                        program.RemoveVehicle(parkingSlot, ticketNumber, vehicleType);

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}