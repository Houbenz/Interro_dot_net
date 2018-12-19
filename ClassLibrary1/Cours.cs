using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
    public class Cours
    {
        int nbrplace;
        int nbreSeance;
        string nomCours;


        public Cours(string nomCours, int nbreplace, int nbreSeance)
        {

        }

        public int Nbrplace
        {
            get
            {
                return nbrplace;
            }

            set
            {
                nbrplace = value;
            }
        }

        public int NbreSeance
        {
            get
            {
                return nbreSeance;
            }

            set
            {
                nbreSeance = value;
            }
        }

        public string NomCours
        {
            get
            {
                return nomCours;
            }

            set
            {
                nomCours = value;
            }
        }

    



    }
}
