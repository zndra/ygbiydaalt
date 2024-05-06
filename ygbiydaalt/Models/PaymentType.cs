using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class PaymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ptID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ptname { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
