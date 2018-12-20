using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Server
{
    public class Impl : MarshalByRefObject, ClassLibrary1.Iteacher, ClassLibrary1.Istudent
    {

        List<Cours> cours = new List<Cours>();
        public Impl()
        {
        
        }

        public List<Cours> afficherCours()
        {

            return cours;
        }

        public bool ajouterCours(Cours c)
        {

            bool exist = false;
                foreach(Cours inside in cours)
            {
                if (inside.NomCours.Equals(c.NomCours))
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                cours.Add(c);
                return true;
            }
            else
                return false;
        }

        public List<Cours> consulterCours()
        {
            return cours;
        }

        public List<string> consulterEleve(string intiule)
        {
           foreach(Cours c in cours)
            {
                if (c.NomCours.Equals(intiule))
                {
                    return c.EtudiantsInscris;
                }
            }
            return null;
        }

        public bool inscrire(string eleve, string intitule)
        {
            foreach (Cours c in cours)
            {
                if (c.NomCours.Equals(intitule) && c.Nbrplace > 0)
                {
                    c.EtudiantsInscris.Add(eleve);
                    c.Nbrplace--;
                    return true;
                }

            }
            return false;
        }

    }
}

    
