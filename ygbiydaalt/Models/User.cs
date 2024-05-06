using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string username { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string pass { get; set; }

        public int typeID { get; set; }

        [ForeignKey("typeID")]
        public UserType UserType { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
