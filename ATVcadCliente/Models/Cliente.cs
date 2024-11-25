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
        public string CPF { get; set; }
        [Required]
        [StringLength(11)]
        public string RG { get; set; }
        [Required]
        [StringLength(10)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(100)]
        public string EstCivil { get; set; }
        [Required]
        [StringLength(100)]
        public DateTime DataNasc { get; set; }
        [Required]
        public string Pai { get; set; }
        public string Mae { get; set; }
    }
}
