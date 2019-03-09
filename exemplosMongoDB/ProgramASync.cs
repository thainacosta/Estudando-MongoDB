using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplosMongoDB
{
    class ProgramASync
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Precione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
            Console.WriteLine("Espere 10 segundos... ");
            await Task.Delay(10000);
            Console.WriteLine("Esperei 10 segundos!");
        }
    }
}
