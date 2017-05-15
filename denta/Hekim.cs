using System.Collections.Generic;
namespace denta
{
    public class Hekim
    {
        public string HName;
        public string HQrafik;

     
        ShowSobe Hekims = new ShowSobe();


        public Hekim(string name,string qrafik ,Sobe sobesi)
        {
            this.HName = name;
            this.HQrafik = qrafik;
            Hekims.AddHekim(this);
           
         

        }

    }
}