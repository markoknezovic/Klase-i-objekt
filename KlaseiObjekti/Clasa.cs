using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti
{
    class Clasa
    {

        string stringUpis;
        int godRod;

        public string StringUpis { get => stringUpis; set => stringUpis = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            string ispis="String "+this.stringUpis + "\r Int: "+ this.godRod;
            return ispis;
        }

        public Clasa(string stringUpis, int godRod)
        {
            this.stringUpis = stringUpis;
            this.godRod = godRod;
        }

    }

}
