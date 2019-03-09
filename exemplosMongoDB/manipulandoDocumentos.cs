using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplosMongoDB
{
    class manipulandoDocumentos
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Precione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
            var doc = new BsonDocument
        {
            {"Título", "Guerra dos Tronos"},
            {"Autor", "George R R Martin"},
            {"Ano", "1999"},
            {"Páginas", "856"}
        };

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");
            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);

        }
    }
}
