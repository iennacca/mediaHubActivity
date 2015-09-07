using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.LocalActivityServiceReference;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ActivityDetailsServiceClient();
            client.InnerChannel.OperationTimeout = new TimeSpan(0, 5, 0);
            var dataList = client.CheckService("Test");
        }
    }
}
