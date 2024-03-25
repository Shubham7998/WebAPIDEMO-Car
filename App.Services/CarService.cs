using App.DTO;
using App.IRepositories;
using App.IServices;
using App.Model;

namespace App.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<GetCarDto> CreateCarAsync(CreateCarDto carDto)
        {
            var car = await _carRepository.CreateAsync(new Car()
            {
                CarTypeId = carDto.CarType,
                CarModel = carDto.CarModel,
                CarPrice = carDto.CarPrice,
            });

            return new GetCarDto(car.CarId, car.CarModel, car.CarPrice, car.CarTypeId);
        }

        public async Task<bool> DeleteCarAsync(int Id)
        {
            var car = await _carRepository.GetByIdAsync(Id);
            if (car != null)
            {
                await _carRepository.DeleteAsync(car);
                return true;
            }
            return false;
        }

        public async Task<GetCarDto> GetCarAsync(int Id)
        {
            var car = await _carRepository.GetByIdAsync(Id);
            return new GetCarDto(car.CarId, car.CarModel, car.CarPrice, car.CarTypeId);
        }

        public async Task<IEnumerable<GetCarDto>> GetCarsAsync()
        {
            var cars = await _carRepository.GetAllAsync();

            var carDto = cars.Select(car => new GetCarDto(car.CarId, car.CarModel, car.CarPrice, car.CarTypeId));

            return carDto;
        }

        public async Task<GetCarDto> UpdateCarAsync(int Id, UpdateCarDto carDto)
        {
            var oldCar =  await _carRepository.GetByIdAsync(Id);

            if (oldCar != null)
            {
                oldCar.CarPrice = carDto.CarPrice;
                oldCar.CarTypeId = carDto.CarType;
                oldCar.CarModel = carDto.CarModel; 

                await _carRepository.UpdateAsync(oldCar);
                 return new GetCarDto(oldCar.CarId, oldCar.CarModel, oldCar.CarPrice, oldCar.CarTypeId);
                
            }

            return null;
        }
    }
}
