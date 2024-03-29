﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using PTSLibrary;

namespace RemoteServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(50000);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PTSLibrary.PTSAdminFacade), "PTSAdminFacade", WellKnownObjectMode.Singleton);

            Console.WriteLine("Press the enter key to terminate server");
            Console.ReadLine();
        }
    }
}
