using System.ComponentModel.DataAnnotations;

namespace AlunosApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "O nome deve ser maior!")]
        [StringLength(80, ErrorMessage = "O nome deve ser menor!")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Formato de E-mail errado.")]
        [StringLength(100, ErrorMessage = "O E-mail deve ser menor")]
        public string Email { get; set;}

        [Required]
        public int Idade { get; set;}
    }
}
