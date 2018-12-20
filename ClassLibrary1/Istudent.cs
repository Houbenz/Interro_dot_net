using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Istudent
    {

        List<Cours> consulterCours();

        bool inscrire(string eleve, string intitule);
    }

}
