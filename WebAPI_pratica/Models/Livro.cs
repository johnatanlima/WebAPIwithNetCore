using System.Collections.Generic;

namespace WebAPI_pratica.Models{
    public class Livro{
        public int ID { get; set; }
        public string Titulo { get; set; }    
        public double Preco { get; set; }   

    }

    public class LivrosEstaticos{
        public static IDictionary<int, Livro> listaLivros;

        //Meus Dados de Produto estáticos, em memória (Criados pelo construtor)
        static LivrosEstaticos(){

            listaLivros = new Dictionary<int, Livro>();

            listaLivros.Add(0, new Livro{ID = 0, Titulo = "Admiravel Mundo Novo", Preco = 39.99});
            listaLivros.Add(1, new Livro{ID = 1, Titulo = "Criptomoedas", Preco = 15.99});
            listaLivros.Add(2, new Livro{ID = 2, Titulo = "Construindo Web APIs", Preco = 49.99});
        }
    }

}