using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    public class Value
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        [Required]
        public string Name { get; set; }
    }
}