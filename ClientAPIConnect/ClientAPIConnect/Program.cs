using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientAPIConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allUsedMethods = String.Empty;
            //allUsedMethods = "asikToJedeSefe";
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            using (StreamReader reader = new StreamReader("WorkingDirectory\\"+args[0]))
            {
                allUsedMethods = reader.ReadToEnd();
            }
            Client.StartClient(allUsedMethods);
            Thread.Sleep(10000);
        }
    }
}
