using Rover_Control_Center.AllProbes;
using Rover_Control_Center.Rovers;
using System;
using System.Security.Cryptography.X509Certificates;

namespace RoverControlCenter
{
    class Program
    {

        // 2. static method that prints all informations of variables in array 
        static void DirectAll( Probe[] directables)
        {
            foreach (var rover in directables)
            {
                Console.WriteLine(rover.GetInfo());
                Console.WriteLine(rover.Explore());
                Console.WriteLine(rover.Collect()); 

            }
        }
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            // 1. creatring array of Rovers
            Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };
            // 4. Creating an array for all space probes
            Object[] objects = new Object[] {lunokhod, apollo, sojourner, sputnik};
            foreach (Object obj in objects) 
            {
                Console.WriteLine($"Tracking: {obj.GetType()} ");
            }
            Console.WriteLine(" ");
            // 8.
            Probe[] dt = new Probe[] { lunokhod, apollo, sojourner, sputnik };
            DirectAll(dt);




        }


        
    }
}
