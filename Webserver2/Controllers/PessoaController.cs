using Microsoft.AspNetCore.Mvc;
using Webserver2.Models;
using System.Linq;

namespace Webserver2.Controllers{
   [Route("api/pessoa")]
    public class PessoaController : Controller
    {
        //Get all pessoas
        [HttpGet]
        public Pessoa[] Get(){
            
            return Repository.listPessoas.ToArray();
        }

        //Get Pessoa por ID
        [HttpGet("{id}")]
        public Pessoa Get(int id){

            return Repository.GetPessoaByID(id);
        } 

        //Criar uma nova pessoa
        [HttpPost]
        public void Post([FromBody] Pessoa pessoa){
            Repository.AddPessoa(pessoa);
        }

        //Atualizar uma pessoa já existente
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa pessoa){

            Repository.ReplacePessoaByID(id, pessoa);
        }

        //Deletar uma pessoa
        [HttpDelete("{id}")]
        public void Delete(int id){
            
            Repository.RemovePessoaByID(id);
        }
    }
}
