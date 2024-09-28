using System;
using System.ComponentModel.DataAnnotations;

namespace ClienteCRUD.Models
{
    public class Cliente
    {
        [Key]
        public int CLI_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CLI_NOME { get; set; } = string.Empty; 

        [DataType(DataType.Date)]
        public DateTime CLI_DATANASCIMENTO { get; set; } = DateTime.Now; 

        public bool CLI_ATIVO { get; set; } = true; 
    }
}
