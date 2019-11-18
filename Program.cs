using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> owlCity = new List<Building>();

            Building Snowy = new Building("612 bare beak bend")
            {
                Width = 20,
                Depth = 20,
                Stories = 6

            };
            Building GreatHorned = new Building("754 whoooo walk")
            {
                Width = 80,
                Depth = 60,
                Stories = 9

            };
            Building Burrowing = new Building("388 talons trail")
            {
                Width = 50,
                Depth = 40,
                Stories = 4

            };
            Building LongEared = new Building("423 whoooo walk")
            {
                Width = 20,
                Depth = 75,
                Stories = 8

            };
            Building Elf = new Building("670 bare beak bend")
            {
                Width = 680,
                Depth = 400,
                Stories = 7

            };
            Building ShortEared = new Building("225b whoooo walk")
            {
                Width = 700,
                Depth = 300,
                Stories = 3

            };
            Building Barn = new Building("547 bare beak bend")
            {
                Width = 600,
                Depth = 25,
                Stories = 1

            };
            Building Spectaled = new Building("124 talons trail")
            {
                Width = 800,
                Depth = 210,
                Stories = 2

            };
            Building Screech = new Building("809 talons trail")
            {
                Width = 300,
                Depth = 760,
                Stories = 6

            };

            Snowy.Construct();
            Snowy.Purchase("Keaton");
            Console.WriteLine(Snowy.Description);

            GreatHorned.Construct();
            GreatHorned.Purchase("Phil");
            Console.WriteLine(GreatHorned.Description);

            Burrowing.Construct();
            Burrowing.Purchase("Alex");
            Console.WriteLine(Burrowing.Description);

            LongEared.Construct();
            LongEared.Purchase("Lauren");
            Console.WriteLine(LongEared.Description);

            Elf.Construct();
            Elf.Purchase("Shirish");
            Console.WriteLine(Elf.Description);

            ShortEared.Construct();
            ShortEared.Purchase("Heidi");
            Console.WriteLine(ShortEared.Description);

            Barn.Construct();
            Barn.Purchase("Dave");
            Console.WriteLine(Barn.Description);

            Spectaled.Construct();
            Spectaled.Purchase("Stephen");

            Console.WriteLine(Spectaled.Description);

            Screech.Construct();
            Screech.Purchase("James");
            Console.WriteLine(Screech.Description);

        }
    }
}