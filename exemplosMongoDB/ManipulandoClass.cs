using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplosMongoDB
{
    class ManipulandoClass
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Precione Enter");
            Console.ReadLine();
        }

        static async Task MainASync(string[] args)
        {
          
            // inicializar uma variavel do tipo Livro 

            Livro livro = new Livro();
            livro.Titulo = "Sob a redoma";
            livro.Autor = "Stephen King";
            livro.Ano = 679;
            livro.Paginas = 2012;

            List<string> listaAssuntos = new List<string>();
            listaAssuntos.Add("Ficcao Cientifica");
            listaAssuntos.Add("Acao");
            listaAssuntos.Add("Terror");
            livro.Assunto = listaAssuntos;



            // acessando o servidor Mongo DB

            string stringConexao = "mongodb://localhost:27017";

            IMongoClient cliente = new MongoClient(stringConexao);

            // acessando o banco de dados 

            IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

            // acessando a colecao 

            IMongoCollection<Livro> colecao = bancoDados.GetCollection<Livro>("Livros");

            // inserindo um documento 

            await colecao.InsertOneAsync(livro);

            Console.WriteLine("Documento inserido");



        }
    }
}
