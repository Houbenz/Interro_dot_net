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

        Cours[] cours = new Cours[100];
        Inscription[] inscritpions = new Inscription[100];
        public Impl()
        {

        }

        public void ajouterCours(Cours c)
        {
            for (int i = 0; i < cours.Length; i++)
            {
                if (cours[i] != null)
                {
                    cours[i] = c;
                    Console.WriteLine(cours[i].NomCours);
                }
            }
        }

        public Cours[] consulterCours()
        {
            Cours[] courPlaceVide = new Cours[100];

            int j = 0;
            for (int i = 0; i < cours.Length; i++)
            {
                if (cours[i] != null && cours[i].Nbrplace > 0)
                {
                    courPlaceVide[j] = cours[i];
                    j++;
                }
            }

            return courPlaceVide;
        }

        public string[] consulterEleve(string intiule)
        {
            string[] eleves = new string[100];

            int j = 0;
            for (int i = 0; i < inscritpions.Length; i++)
            {
                if (inscritpions[i] != null && intiule.Equals(inscritpions[i].NomCours))
                {
                    eleves[j] = inscritpions[i].Eleve;
                    j++;
                }
            }
            return eleves;

        }

        public bool inscrire(string eleve, string intitule)
        {
             for (int i = 0; i < cours.Length; i++)
            {
                if (cours[i] != null && cours[i].NomCours.Equals(intitule))
                {
                    if (cours[i].Nbrplace > 0)
                    {
                        for (int j = 0; j < inscritpions.Length; j++)
                        {
                            if (inscritpions[j] == null)
                            {
                                inscritpions[j] = new Inscription(eleve, intitule);
                                cours[i].Nbrplace--;
                                return true;
                            }
                        }
                    }

                }
            }

            return false;
        }

    }
}

    
