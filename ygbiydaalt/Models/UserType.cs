using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class UserType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int typeID { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string typename { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
