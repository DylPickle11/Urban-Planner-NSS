using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City chirpCity = new City("chirpCity")
            {
                Mayor = "Chirpy",
                Established = 1895
            };
            City hootHaven = new City("hootHaven")
            {
                Mayor = "Hooty",
                Established = 1954

            };
            City growlGarden = new City("growlGarden")
            {
                Mayor = "Growly",
                Established = 1995
            };

            Building Snowy = new Building("612 bare beak bend", "Snowy")
            {
                Width = 20,
                Depth = 20,
                Stories = 6

            };
            Building GreatHorned = new Building("754 whoooo walk", "GreatHorned")
            {
                Width = 80,
                Depth = 60,
                Stories = 9

            };
            Building Burrowing = new Building("388 talons trail", "Burrowing")
            {
                Width = 50,
                Depth = 40,
                Stories = 4

            };
            Building LongEared = new Building("423 whoooo walk", "LongEared")
            {
                Width = 20,
                Depth = 75,
                Stories = 8

            };
            Building Elf = new Building("670 bare beak bend", "Elf")
            {
                Width = 680,
                Depth = 400,
                Stories = 7

            };
            Building ShortEared = new Building("225b whoooo walk", "ShortEared")
            {
                Width = 700,
                Depth = 300,
                Stories = 3

            };
            Building Barn = new Building("547 bare beak bend", "Barn")
            {
                Width = 600,
                Depth = 25,
                Stories = 1

            };
            Building Spectaled = new Building("124 talons trail", "Spectaled")
            {
                Width = 800,
                Depth = 210,
                Stories = 2

            };
            Building Screech = new Building("809 talons trail", "Screech")
            {
                Width = 300,
                Depth = 760,
                Stories = 6

            };

            Snowy.Construct();
            Snowy.Purchase("Keaton");
            //Console.WriteLine(Snowy.Description);
            chirpCity.AddBuilding(Snowy);

            GreatHorned.Construct();
            GreatHorned.Purchase("Phil");
            //Console.WriteLine(GreatHorned.Description);
            hootHaven.AddBuilding(GreatHorned);

            Burrowing.Construct();
            Burrowing.Purchase("Alex");
            //Console.WriteLine(Burrowing.Description);
            growlGarden.AddBuilding(Burrowing);

            LongEared.Construct();
            LongEared.Purchase("Lauren");
            // Console.WriteLine(LongEared.Description);
            //chirpCity.AddBuilding(LongEared);

            Elf.Construct();
            Elf.Purchase("Shirish");
            //Console.WriteLine(Elf.Description);
            growlGarden.AddBuilding(Elf);

            ShortEared.Construct();
            ShortEared.Purchase("Heidi");
            //Console.WriteLine(ShortEared.Description);
            //hootHaven.AddBuilding(ShortEared);

            Barn.Construct();
            Barn.Purchase("Dave");
            //Console.WriteLine(Barn.Description);
            growlGarden.AddBuilding(Barn);

            Spectaled.Construct();
            Spectaled.Purchase("Stephen");
            //Console.WriteLine(Spectaled.Description);
            chirpCity.AddBuilding(Spectaled);

            Screech.Construct();
            Screech.Purchase("James");
            //Console.WriteLine(Screech.Description);
            hootHaven.AddBuilding(Screech);

            foreach (Building building in chirpCity.Buildings)
            {
                Console.WriteLine($"{chirpCity.Name} has these buildings:{building.Name}");
            };

            foreach (Building building in hootHaven.Buildings)
            {
                Console.WriteLine($"{hootHaven.Name} has these buildings:{building.Name}");
            };

            foreach (Building building in growlGarden.Buildings)
            {
                Console.WriteLine($"{growlGarden.Name} has these buildings:{building.Name}");
            };

        }
    }
}