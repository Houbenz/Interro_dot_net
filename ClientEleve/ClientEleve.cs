using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClientEleve
{
    class ClientEleve
    {

        static void Main(string[] args)
        {
            TcpChannel chnl = new TcpChannel();
            ChannelServices.RegisterChannel(chnl, false);

            Istudent eleve = (Istudent)Activator.GetObject(typeof(Istudent), "tcp://localhost:1111/Impl");

            Console.WriteLine("Eleve");
         

       
            Console.WriteLine(eleve.inscrire("houcine", "SD"));

            Console.WriteLine(eleve.inscrire("houcine", "PFL"));

    


        }
    }
}
