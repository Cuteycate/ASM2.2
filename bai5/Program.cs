namespace bai5
{


class Program
{
    static void Main()
    {
        // Tạo danh sách các xe tải
        List<Truck> trucks = new List<Truck>()
        {
            new Truck("Xe Tải A", 5000),
            new Truck("Xe Tải B", 3000),
            new Truck("Xe Tải C", 7000),
            new Truck("Xe Tải D", 4000)
        };

        // Sắp xếp danh sách theo trọng tải tăng dần
        trucks.Sort((x, y) => x.Payload.CompareTo(y.Payload));

        // In ra danh sách đã sắp xếp
        foreach (var truck in trucks)
        {
            Console.WriteLine($"Tên: {truck.Name}, Trọng tải: {truck.Payload}");
        }
    }
}

class Truck
{
    public string Name { get; set; }
    public int Payload { get; set; }

    public Truck(string name, int payload)
    {
        Name = name;
        Payload = payload;
    }
}
}