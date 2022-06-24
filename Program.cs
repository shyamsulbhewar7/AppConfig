using AppConfigV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigRead config = new ConfigRead();
            Console.WriteLine("{0}", config.GetConnection1());
            Console.WriteLine("{0}", config.GetConnection1());
            Console.WriteLine("");
            Console.WriteLine("{0}", config.GetServer());
            Console.WriteLine("{0}", config.GetDatabase());
            Console.ReadKey();
        }
    }
}
