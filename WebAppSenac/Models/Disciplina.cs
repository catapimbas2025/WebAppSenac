using System.ComponentModel.DataAnnotations;

namespace WebAppSenac.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        [Required]        
        public int CargaHoraria { get; set; }
               
        
    }
}
