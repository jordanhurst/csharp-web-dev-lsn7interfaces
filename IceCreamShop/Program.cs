using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            availableFlavors.Sort(new FlavorComparer());

            availableCones.Sort(new ConeComparer());

            string flavorDisplay = "";
            string coneDisplay = "";

            foreach(Flavor f in availableFlavors)
            {
                flavorDisplay += f.Name + "\n";
            }

            foreach(Cone c in availableCones)
            {
                coneDisplay += c.Name + ": $" + c.Cost + "\n";
            }

            Console.WriteLine(flavorDisplay);
            Console.WriteLine(coneDisplay);
        }
    }
}
