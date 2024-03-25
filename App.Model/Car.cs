using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Model
{
    [Table("Cars")]

    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }

        [Required (ErrorMessage = "Please enter car model")]
        [MaxLength (20)]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "Please enter car price")]
        public int CarPrice { get; set; }

        [Required(ErrorMessage = "Please enter car type")]
        public int CarType { get; set; }

    }
}
