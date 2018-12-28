using System.Collections.Generic;
using System.Linq;
using System;

namespace Webserver2.Models{
    public class Repository{

        private static int contador;
        public static IList<Pessoa> listPessoas {get;} = new List<Pessoa>();
       
        public static Pessoa GetPessoaByID(int id){
            var target = listPessoas.SingleOrDefault(p=> p.ID == id);

            return target;
        }

        public static void RemovePessoaByID(int id){
            var target = listPessoas.SingleOrDefault(p=> p.ID == id);

            if(target != null)
                listPessoas.Remove(target);            
        }
        
        public static void ReplacePessoaByID(int id, Pessoa pessoa){
            var target = listPessoas.SingleOrDefault(p=> p.ID == id);

             if(target != null){
                 listPessoas.Remove(target);
                 listPessoas.Add(pessoa);
             }
        }

        public static void AddPessoa(Pessoa pessoa){
            pessoa.ID = contador++;
            listPessoas.Add(pessoa);
        }


    }
}