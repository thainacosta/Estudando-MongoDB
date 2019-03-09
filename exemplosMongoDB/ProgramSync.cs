using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplosMongoDB
{
    class ProgramSync
    {
        static void Main(string[] args)
        {
            MainSync(args);
            Console.WriteLine("Precione Enter");
            Console.ReadLine();
        }

        static void MainSync(string[] args)
        {
            Console.WriteLine("Espere 10 segundos... ");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Esperei 10 segundos!");
        }
    }
}
