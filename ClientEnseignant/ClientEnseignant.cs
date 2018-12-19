using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClientEnseignant
{
    class ClientEnseignant
    {
        static void Main(string[] args)
        {
            TcpChannel chnl = new TcpChannel();
            ChannelServices.RegisterChannel(chnl, false);

            Iteacher teacherImp = (Iteacher)Activator.GetObject(typeof(Iteacher), "tcp://localhost:1111/file");

            Console.WriteLine("Enseignant");

            Console.WriteLine(teacherImp.ajouterCours(new Cours("SR", 3, 1)));
            Console.WriteLine(teacherImp.ajouterCours(new Cours("SD", 0, 2)));
            Console.WriteLine(teacherImp.ajouterCours(new Cours("PLF", 4, 2)));
            
     
            Cours[] cours = teacherImp.afficherCours();
            for(int i = 0; i < cours.Length; i++)
            {
                Console.WriteLine(cours[i].NomCours);
            }

            Console.ReadLine();

        }
    }
}
