using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudtst.Models
{
    [Table("Fornecedores")]
    public class Fornecedores
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Digite o Nome corretamente")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o CNPJ corretamente")]
        [Column(TypeName = "nvarchar(14)")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Selecione uma especialidade")]
        public string Especialidade { get; set; }   
    }
}
