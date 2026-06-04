namespace ParkingLot
{
    public class ParkingSlot
    {
        public Vehicle[,] BikeSlots;
        public Vehicle[,] CarSlots;
        public Vehicle[,] TruckSlots;

        public ParkingSlot()
        {
            Console.WriteLine("Enter Bike Parking Rows:");
            int bikeRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Bike Parking Columns:");
            int bikeColumns = int.Parse(Console.ReadLine());

            BikeSlots = new Vehicle[bikeRows, bikeColumns];
            AssignZero(BikeSlots);

            Console.WriteLine("Enter Car Parking Rows:");
            int carRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Car Parking Columns:");
            int carColumns = int.Parse(Console.ReadLine());

            CarSlots = new Vehicle[carRows, carColumns];
            AssignZero(CarSlots);

            Console.WriteLine("Enter Truck Parking Rows:");
            int truckRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Truck Parking Columns:");
            int truckColumns = int.Parse(Console.ReadLine());

            TruckSlots = new Vehicle[truckRows, truckColumns];
            AssignZero(TruckSlots);
        }

        void AssignZero(Vehicle[,] slots)
        {
            int r = slots.GetLength(0);
            int c = slots.GetLength(1);

            for(int i = 0; i < r; i++)
            {
                for(int j = 0;j<c; j++)
                {
                    slots[i, j] = null;
                }
            }
        }
    }
}