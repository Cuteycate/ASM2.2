namespace bai4
{
    internal interface ICar2
    {
        string Name { get; init; }
        int Seats { get; init; }

        void Deconstruct(out string Name, out int Seats);
        bool Equals(Car? other);
        bool Equals(object? obj);
        int GetHashCode();
        string ToString();
    }
}