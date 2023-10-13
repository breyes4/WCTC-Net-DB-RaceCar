using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class EnzoG : Driver
    {
        public EnzoG(RaceCar car) : base(car)
        {
            Name = "Enzo Giuseppe";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} is driving ver volatile and loses control over the steering wheel and causes engine to run out");
        }
    }
}
