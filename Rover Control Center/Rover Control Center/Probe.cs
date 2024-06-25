using Rover_Control_Center.AllProbes;

namespace RoverControlCenter
{
    class Probe
    {
        public string Alias
        { get; protected set; }


        public Probe(string alias)
        {
            Alias = alias;

        }
        public virtual string GetInfo()
        {
            return ToString();
        }
        public virtual string Explore()
        {
            return ToString();
        }
        public virtual string Collect()
        {
            return ToString();
        }
    }
}