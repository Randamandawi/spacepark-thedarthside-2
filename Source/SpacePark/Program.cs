﻿using System;
using static SpacePark.Person;
using System.Linq;
using System.Threading.Tasks;


namespace SpacePark
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var context = new Context();
            var p = new PersonDataAccess(context);
            //await p.AddPersonAsync(new Person { FirstName = "Anton", LastName = "Johansson" });
           var listOfPeople = await  p.GetListOfPeople();
            // lägga detta så att man kan välja vilken man vill ta bort när någon lämnar 
            //Parkeringen
            int i = 0;
            foreach (var l in listOfPeople)
            {
                i++;
            }
                Console.WriteLine($"{i} ");
            Console.WriteLine("Press any key...");
            Console.ReadKey();

            //var parking = new ParkingHouse();
            //var x = parking.CheckAvailableParking();
            //Console.WriteLine(x);




            Console.ReadKey();


        }
    }
}
