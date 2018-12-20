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
        List<String> etudiantsInscris;

        public Cours(string nomCours, int nbreplace, int nbreSeance)
        {
            this.nomCours = nomCours;this.Nbrplace = nbreplace;this.nbreSeance = nbreSeance;
            EtudiantsInscris = new List<string>();
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

        public List<string> EtudiantsInscris
        {
            get
            {
                return etudiantsInscris;
            }

            set
            {
                etudiantsInscris = value;
            }
        }
    }
}
