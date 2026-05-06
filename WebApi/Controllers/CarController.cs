using Microsoft.AspNetCore.Mvc;
using APIVentaDeAutos.Application.Services;
using APIVentaDeAutos.Domain.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace APIVentaDeAutos.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CarController : ControllerBase
	{
		private readonly CarService _carService;

		public CarController(CarService carService)
		{
			_carService = carService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var cars = await _carService.GetAllCarsAsync();
			return Ok(cars);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var car = await _carService.GetCarByIdAsync(id);
			if (car == null) return NotFound();
			return Ok(car);
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] Car car)
		{
			await _carService.AddCarAsync(car);
			return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(string id, [FromBody] Car car)
		{
			car.Id = id;
			await _carService.UpdateCarAsync(car);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string id)
		{
			await _carService.DeleteCarAsync(id);
			return NoContent();
		}
	}
}
