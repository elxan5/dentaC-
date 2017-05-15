using System;
using System.Collections.Generic;
namespace denta
{
    public class Xeste
    {
        public string XName;



        public Xeste(string xname)
        {
            this.XName = xname;
        }
     
        static public void ShownameX()
        {
            Console.Write("Adinizi daxil edin: ");
            var s = Console.ReadLine();
            var xeste = new Xeste(s);
            
            Console.WriteLine(s+" Xos gelmisiniz \n");
        }
      
     

    }
}