using System;
using System.Collections.Generic;
namespace denta
{
    class ShowSobe
    {
        static public List<Sobe> Listsobe = new List<Sobe>();
        public static List<Hekim> listHekim = new List<Hekim>();



        public static Hekim ShowHekim(int number)
        {
            Console.WriteLine("Hekimin adi:"+listHekim[number-1].HName+listHekim[number-1].HQrafik);
            return listHekim[number - 1];
            
        }
        public static Sobe showsobe(int num)
        {

            if (num>Listsobe.Count&& num < 0)
            {
                Console.WriteLine("Bele sobe yoxdur...");
                AllSobe();
            }
            else
            {
                Console.WriteLine("Sobenin adi "+Listsobe[num-1].SName);
               
                return Listsobe[num - 1];
            }
            return null;
        }
        public static int input(string message)
        {
            Console.Write(message);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }
        public static void AllSobe()
        {
            int nom = 0;
            foreach (var sobe in Listsobe)
            {
                nom++;
                Console.WriteLine(nom+"."+sobe.SName);
            }

        }
       
        public static void AllHekim()
        {
            int nm = 0;
            foreach (var hekm in listHekim)
            {
                nm++;
                Console.WriteLine(nm+"."+hekm.HName+hekm.HQrafik);
            }
        }
        public void AddSobe(Sobe obj)
        {
            Listsobe.Add(obj);
        }
       
        public void AddHekim(Hekim ob)
        {
            listHekim.Add(ob);
        }

    }
}