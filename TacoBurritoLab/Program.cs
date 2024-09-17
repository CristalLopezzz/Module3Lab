// See https://aka.ms/new-console-template for more information
using System;
namespace TacoBurritoLab
 {   
    class Program
    {
        static void Main(string[] args) 
         {
                Console.WriteLine("Welcome To The Taco & Burrito Decision Maker!");

                Console.Write("How hungry are you (1-10)? ");
                int hungerLevel = int.Parse(Console.ReadLine());

                if(hungerLevel >=8)
                {
                    Console.WriteLine("You're super hungry! Order both tacos and burritos.");
                }
                else if (hungerLevel >= 5)
                {
                    Console.WriteLine("You are moderately hungry. Go for tacos!");
                }
                else 
                {
                    Console.WriteLine("You're no that hungry. Opt for a burrito.");
                }

                string recommendation = (hungerLevel >=5)? "Tacos" : "Burritos";
                Console.WriteLine($"I recommend: {recommendation}");

                switch(hungerLevel) 
                {
                    case 10:
                        Console.WriteLine("You're a taco and burrito champion!");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Taco time!");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Burrito it is!");
                        break;
                    default:
                        Console.WriteLine("Maybe just grab a snack.");
                        break;
                
                   
                }
         } //end main method
     } //end program class
 } // end namespace
