using System;
using Newtonsoft.Json;

namespace SerializingJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto Produto
            var produto1 = new Produto{ id = 100, nome = "Mesa", preco = 10.99};
    
            //Serializando o objeto produto1 para JSON
            var jsonString = JsonConvert.SerializeObject(produto1);
            System.Console.WriteLine(jsonString);

            //Deserializando o JsonString para um objeto produto1 novamente. 
            var produto2 = JsonConvert.DeserializeObject<Produto>(jsonString);
            System.Console.WriteLine($"O ID do produto é {produto2.id}");
            System.Console.WriteLine($"O Nome do produto é {produto2.nome}");
            System.Console.WriteLine($"O Preco do produto é {produto2.preco}");


            
            
        }
    }

    //Criando uma classe modelo
    class Produto{
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
    }
}
