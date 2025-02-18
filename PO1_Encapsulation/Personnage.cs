using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int puissanceDAttaque;


        public int PointDeVie { get => pointDeVie;
            set {

                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else
                {
                    pointDeVie = value;
                }
            } }


        public int PuissanceDAttaque { get => puissanceDAttaque; set => puissanceDAttaque = value; }

        public bool EstMort
        {
            if(pointDeVie == 0 )
            {
              return true;
            }
            else
            {
              return false;
            }
       }
    }
    
     
}
