using System;

namespace airplaneClass {
    public class Plane
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public void Fly()
        {
            Console.WriteLine("Zoom, zoom");
        }

        public void Info() {
            Console.WriteLine($"A {Make} {Model} has {NumberOfSeats} seats");
        }
    }
}