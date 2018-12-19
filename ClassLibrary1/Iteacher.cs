using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Iteacher
    {
        void ajouterCours(Cours cours);
        string[] consulterEleve(string intiule);

    }
}
