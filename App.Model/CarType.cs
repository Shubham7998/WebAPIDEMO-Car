using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    [Table("CarTypes")]
    public class CarType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarTypeId { get; set; }

        [Required(ErrorMessage = "Please enter car type")]
        [MaxLength(10)]

        public string TypeName { get; set; }
    }
}
