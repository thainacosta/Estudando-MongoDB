using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplosMongoDB
{
    class AcessandoMongoDB
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

           

            // acessando o servidor Mongo DB

            string stringConexao = "mongodb://localhost:27017";

            IMongoClient cliente = new MongoClient(stringConexao);

            // acessando o banco de dados 

            IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

            // acessando a colecao 

            IMongoCollection<BsonDocument> colecao = bancoDados.GetCollection<BsonDocument>("Livros");

            // inserindo um documento 

            await colecao.InsertOneAsync(doc);

            Console.WriteLine("Documento inserido");



        }
    }
}
