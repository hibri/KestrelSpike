#define DefaultBuilder
// Define any of the following for the scenarios described in the Kestrel topic:
// DefaultBuilder Limits TCPSocket UnixSocket FileDescriptor Port0 SyncIO
// The following require an X.509 certificate:
// TCPSocket UnixSocket FileDescriptor Limits

using System;
using System.Net;
using Microsoft.Extensions.Hosting;


namespace KestrelSpike
{
    public class Program
    {

  
        public static void Main(string[] args)
        {
            
        }


        private void buildServer()
        {
            var hostBuilder = new HostBuilder();
            
        }

        
    }
}