using System;
using System.Reflection;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double areFloorPlan = Rect(2500, 1500) + Triangle(750, 500) + (0.5 * Circle(375));
            double totalAreaCost = Math.Round((areFloorPlan * 180), 2);

            Console.WriteLine("How expensive is one of the famous buildings?");
            Console.WriteLine("Which building costs you want to check?");
            Console.Write("Choose one of the: \n1.TEOTIHUACAN \n2.TAJMAHAL \n3.GREAT MOSQUE OF MECCA \nType here: ");
            string choice = Console.ReadLine();
            string choiceUpper = choice.ToUpper();

            if (choiceUpper == "TEOTIHUACAN" || choiceUpper == "1")
            {
                Console.WriteLine($"Total cost of your floor is {totalAreaCost} pesos");
            }
            else if (choiceUpper == "TAJMAHAL" || choiceUpper == "2")
            {
                Console.WriteLine($"Total cost of your floor is {TajMahal()} pesos");
            }
            else if (choiceUpper == "GREAT MOSQUE OF MECCA" || choiceUpper == "GREATMOSQUEOFMECCA" || choiceUpper == "3")
            {
                Console.WriteLine($"Total cost of your floor is {GreatMosqueOfMecca()} pesos");
            }


        }
        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * (bottom * height);
        }
        static double TajMahal(double rect = 90.5, double trian = 24)
        {
            double areaRect = rect * rect;
            double areaTrain = 0.5 * trian * trian;
            double areaTajMahal = areaRect - (areaTrain * 4);
            double totalCostTajMahal = Math.Round((areaTajMahal * 180), 2);
            return totalCostTajMahal;
        }
        static double GreatMosqueOfMecca(double length = 180,
            double width = 106,
            double lenght2 = 200,
            double width2 = 264,
            double bottom = 264,
            double height = 84)
        {
            double areaSmallRect = length * width;
            double areaBigRect = lenght2 * width2;
            double areaTrian = 0.5 * (bottom * height);
            double totalArea = areaSmallRect + areaBigRect + areaTrian;
            double totalCost = Math.Round((totalArea * 180), 2);
            return totalCost;

        }

    }

}
