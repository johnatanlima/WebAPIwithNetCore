using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPI_pratica.Models;

namespace WebAPI_pratica.Controllers {

    [Route("api/[controller]")]
    public class LivrosController : ControllerBase {
        
        [HttpGet]
        public Livro[] GetLivros(){

            return LivrosEstaticos.listaLivros.Values.ToArray();
        }

        [HttpGet("{id}")]
        public Livro GetLivroByID(int id) {
         
        if (LivrosEstaticos.listaLivros.ContainsKey(id))
        
        return LivrosEstaticos.listaLivros[id];
            else
                return null;    
        }

        [HttpPost] //Passar pelo corpo da requisicao um novo livro (livroParam)
                    //O ID dele vai ser definido pela funcao .Max() + 1 e add na listalivro
        public Livro CreateLivro([FromBody]Livro livroParam) {
            livroParam.ID = LivrosEstaticos.listaLivros.Keys.Max() + 1;
            LivrosEstaticos.listaLivros.Add(livroParam.ID, livroParam);
            
            return livroParam; // E retorna esse livro com seu ID definido
        }

        [HttpPut("{id}")]
        public void UpdateLivroByID(int id, [FromBody]Livro livroParam) {
        
            if (LivrosEstaticos.listaLivros.ContainsKey(id)) {
                var updadeLivro = LivrosEstaticos.listaLivros[id];
        
                updadeLivro.ID = livroParam.ID;
                updadeLivro.Titulo = livroParam.Titulo;
                updadeLivro.Preco = livroParam.Preco;
            }
        }
        [HttpDelete("{id}")]
        public void DeleteLivroByID(int id){
            if (LivrosEstaticos.listaLivros.ContainsKey(id)){
                LivrosEstaticos.listaLivros.Remove(id);
            }
        }
        
    }
}