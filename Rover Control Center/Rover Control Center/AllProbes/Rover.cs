using RoverControlCenter;

namespace Rover_Control_Center.Rovers
{
    class Rover : Probe
    {

        public int YearLanded
        { get; private set; }

        public Rover(string alias, int yearLanded) : base(alias)
        {
            YearLanded = yearLanded;
        }


        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        public override string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}