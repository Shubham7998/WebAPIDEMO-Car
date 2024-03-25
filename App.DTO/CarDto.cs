using System.ComponentModel.DataAnnotations;

namespace App.DTO
{
    public record CreateCarDto([Required (ErrorMessage = "Please enter car model")] string CarModel, [Required(ErrorMessage = "Please enter car price")] int CarPrice, [Required(ErrorMessage = "Please enter car type")] int CarType);
    public record UpdateCarDto(int Id, [Required (ErrorMessage = "Please enter car model")] string CarModel, [Required(ErrorMessage = "Please enter car price")] int CarPrice, [Required(ErrorMessage = "Please enter car type")] int CarType);
    public record GetCarDto(int Id, string CarModel,  int CarPrice, int CarType);
}
