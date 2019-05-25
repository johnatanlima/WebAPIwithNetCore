using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApiEF.Models
{
   [Table("ator")]
    public class Ator {
    
        [Key, Column("ator_id")]
        public int ID { get; set; }

        [Column("primeiro_nome")]
        public string PrimeiroNome { get; set; }

        [Column("ultimo_nome")]
        public string UltimoNome { get; set; }
    }
}