using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int modelID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string modelName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
