using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Iteacher
    {
        bool ajouterCours(Cours cours);
        List<string> consulterEleve(string intiule);
         List<Cours> afficherCours();
    }
}
