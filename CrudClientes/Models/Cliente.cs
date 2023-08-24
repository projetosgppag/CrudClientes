using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudClientes.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Display(Name ="Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name ="Name")]
        [Column("Name")]
        public string? Name { get; set; }
        [Display(Name ="Email")]
        [Column("Email")]
        public string? Email { get; set; }
        [Display(Name ="Telephone")]
        [Column("Telephone")]
        public string? Telephone { get; set; }
    }
}
