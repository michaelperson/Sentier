using Sentier.Models;
using Sentier.Models.Interfaces;
using System;

namespace Sentier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Plante tournesol = new Plante();

            DisplayInEn(tournesol);
        }

        static void DisplayInFrench(IFrancais maPlante)
        {
            Console.WriteLine(maPlante.Nom);
        }

        static void DisplayInEn(IAnglais maPlante)
        {
            Console.WriteLine(maPlante.Nom);
        }

        static void DisplayInNL(INeerlandais maPlante)
        {
            Console.WriteLine(maPlante.Nom);
        }
    }
}
