using App.IServices;
using App.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        // GET: api/<CarController>
        [HttpGet]
        public Task<IEnumerable<Car>> Get()
        {
            return _carService.GetCarsAsync();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public async Task<Car> Get(int id)
        {
            return await _carService.GetCarAsync(id);
        }

        // POST api/<CarController>
        [HttpPost]
        public async Task<Car> Post([FromBody] Car car)
        {
            return await _carService.CreateCarAsync(car);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public async Task<Car> Put(int id, [FromBody] Car car)
        {
            return await _carService.UpdateCarAsync(id, car);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _carService.DeleteCarAsync(id);
        }
    }
}
