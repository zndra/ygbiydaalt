using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int saleID { get; set; }
        public int carID { get; set; }
        [ForeignKey("carID")]
        public Car Cars { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public User Users { get; set; }
        public DateTime? saledate { get; set; }
    }
}
