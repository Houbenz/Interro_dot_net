using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
    public class Inscription
    {
        string eleve;
        string nomCours;
        public Inscription(string eleve,string nomCours)
        {
            this.Eleve = eleve;this.NomCours = nomCours;
        }

        public string Eleve
        {
            get
            {
                return eleve;
            }

            set
            {
                eleve = value;
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
