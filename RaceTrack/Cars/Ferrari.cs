using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Ferrari : RaceCar
    {
        public Ferrari() 
        {
            Name = "Red Ferrari";
            TopSpeed = 120;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is ready to race!"); ;
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} abrubtly starts slowing down");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} blows a tire and is out of the race.");
        }
    }
}
