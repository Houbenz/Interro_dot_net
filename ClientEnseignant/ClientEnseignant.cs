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

            Iteacher teacherImp = (Iteacher)Activator.GetObject(typeof(Iteacher), "tcp://localhost:1111/Impl");

            Console.WriteLine("Enseignant");

            teacherImp.ajouterCours(new Cours("SR", 3, 1));
            teacherImp.ajouterCours(new Cours("SD", 0, 2));
            teacherImp.ajouterCours(new Cours("PLF", 4, 2));

           string[] elve=  teacherImp.consulterEleve("SD");
            for(int i = 0; i < elve.Length; i++)
            {
                Console.WriteLine(elve[i]);
            }


        }
    }
}
