namespace bai4
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            {
                new Car("Xe A", 4);
                new Car("Xe B", 7);
                new Car("Xe C", 5);
                new Car("Xe D", 9);
        }

            int maxSeats = -1;
            Car? maxSeatsCar = null;

            foreach (Car car in cars)
            {
                if (car.Seats > maxSeats)
                {
                    maxSeats = car.Seats;
                    maxSeatsCar = car;
                }
            }

            if (maxSeatsCar != null)
            {
                Console.WriteLine($"Xe ô tô có số chỗ ngồi nhiều nhất là {maxSeatsCar.Name} với {maxSeats} chỗ.");
            }
        }
    }

    class Car
    {
        public string Name { get; set; }
        public int Seats { get; set; }

        public Car(string name, int seats)
        {
            Name = name;
            Seats = seats;
        }
    }
}