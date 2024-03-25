using App.DTO;
using App.Model;

namespace App.IServices
{
    public interface ICarService
    {
        public Task<GetCarDto> CreateCarAsync(CreateCarDto carDto);
        public Task<GetCarDto> UpdateCarAsync(int Id, UpdateCarDto carDto);
        public Task<bool> DeleteCarAsync(int Id);
        public Task<GetCarDto> GetCarAsync(int Id);
        public Task<IEnumerable<GetCarDto>> GetCarsAsync();
    }
}
