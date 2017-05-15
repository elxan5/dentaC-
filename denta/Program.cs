using System;
using System.Collections.Generic;

namespace denta
{
    class Program
    {

        static void Main(string[] args)
        {
            Xeste.ShownameX();
            Console.WriteLine("Sobeler");
            Sobe sobe1 = new Sobe("Tromotologiya");

            Sobe sobe2 = new Sobe("Rentgen");
            Sobe sobe3 = new Sobe("Kordiologiya");
            Sobe sobe4 = new Sobe("Teropiya");
            Sobe sobe5 = new Sobe("Reanimasiya");
            ShowSobe.AllSobe();
            var SobeSelect=ShowSobe.showsobe(ShowSobe.input("Sobe secin: "));
            
            

        }
    }
}