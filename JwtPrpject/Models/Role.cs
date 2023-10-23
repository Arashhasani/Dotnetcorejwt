using System.ComponentModel.DataAnnotations;

namespace JwtPrpject.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
