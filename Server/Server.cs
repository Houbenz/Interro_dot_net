using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel chnl = new TcpChannel(1111);
            ChannelServices.RegisterChannel(chnl, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Impl), "Impl", WellKnownObjectMode.Singleton);
            Console.WriteLine("server is running");
            Console.ReadLine();

        }
    }
}
