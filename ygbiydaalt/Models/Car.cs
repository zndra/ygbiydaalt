using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ygbiydaalt.Models
{
    public class Car
    {
        [Key]
        [Display(Name = "Машины дугаар")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int carID { get; set; }

        [Required(ErrorMessage = "Please enter the car name.")]
        [Display(Name = "Машины нэр")]
        public string carName { get; set; }

        [Display(Name = "Туулах зай")]
        public string range { get; set; }   

        [Display(Name = "Дээд хурд")]
        public string topspeed { get; set; }

        [Display(Name = "Хурд авах хугацаа")]
        public string asctime { get; set; }

        [Required(ErrorMessage = "Please enter the model.")]
        [Display(Name = "Загвар")]
        public int modelID { get; set; }
        [ForeignKey("modelID")]
        public CarModel CarModels { get; set; } 

        [Column(TypeName = "decimal(18,2)")]    
        [Display(Name = "Үнэ")]
        public int price { get; set; }

        [Required(ErrorMessage = "Please enter the image URL.")]
        [Display(Name = "Зураг")]
        public string imagepath { get; set; }
        [Display(Name = "Гадна өнгө")]
        public string excolor { get; set; }
        [Display(Name = "Дотор өнгө")]
        public string incolor { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
