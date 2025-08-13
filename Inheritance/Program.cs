using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal: DONE
            // give this class 4 members that all Animals have in common: DONE


            // Create a class Bird: DONE
            // give this class 4 members that are specific to Bird: DONE
            // Set this class to inherit from your Animal Class: DONE

            // Create a class Reptile: DONE
            // give this class 4 members that are specific to Reptile: DONE
            // Set this class to inherit from your Animal Class: DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "Blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;

            var myLizard = new Reptiles()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                RenerateTail = true

            };

            var myAnimals = new Animal[]{myBird, myLizard};

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age}");
                Console.WriteLine($"it has:{animal.LegCount} legs.");
                Console.WriteLine($"It dominantly dwells in:{animal.LandSeaAir}.");
                Console.WriteLine();
            }
            ;
        }
    }
}
