using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Quadralotes")] 
    public class  QuadraLote  
    {
        [Key]   
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome é Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Quadra é Obrigatório")]
        public string Quadra { get; set; }

        [Required(ErrorMessage = "Lote é Obrigatório")]
        public string lote { get; set; }

        [Required(ErrorMessage = "Email é Obrigatório")]
            public string Email { get; set; }

        [Required(ErrorMessage = "Telefone é Obrigatório")]
        public string Telefone { get; set; }
    }

}
