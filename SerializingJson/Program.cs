using System;

namespace SerializingJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto Produto
            var produto1 = new Produto(){ id = 100, nome = "Mesa", preco = 10.99};
    
        }
    }

    //Criando uma classe modelo
    class Produto{
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
    }
}
