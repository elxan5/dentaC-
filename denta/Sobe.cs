using System.Collections.Generic;
using System;

namespace denta
{
    public class Sobe
    {
        public string SName;

        ShowSobe inc = new ShowSobe();
        public Sobe(string sname)
        {
            this.SName = sname;
            inc.AddSobe(this);


        }
    }
}