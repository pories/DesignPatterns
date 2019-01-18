using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // The 'RealSubject' class
    public class RealClient : IClient
    {
        string Data;
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            Data = "This is the data!";
        }

        public string GetData()
        {
            return Data;
        }
    }
}
