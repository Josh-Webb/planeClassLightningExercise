using System;

namespace airplaneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create new console app
            // - Create a class for Plane
            // - Plane class should have these properties: Make, Model, and NumberOfSeats
            // - Plane should have a Fly method. All it should do is print something to the console

            var jumboJet = new Plane(){
                Make = "Boeing",
                Model = "747",
                NumberOfSeats = 416
            };

            var tieFighter = new Plane(){
                Make = "Tie",
                Model = "Fighter",
                NumberOfSeats = 2
            };

            Console.WriteLine(jumboJet.Make);
            jumboJet.Info();
            tieFighter.Fly();
            tieFighter.Info();
        }
    }
}
