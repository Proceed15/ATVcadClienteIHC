using System.ComponentModel.DataAnnotations;

namespace ATVcadCliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Pai { get; set; }
    }
}
