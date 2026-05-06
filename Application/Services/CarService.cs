using APIVentaDeAutos.Domain.Interfaces;
using APIVentaDeAutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIVentaDeAutos.Application.Services
{
	public class CarService
	{
		private readonly ICarRepository _carRepository;

		public CarService(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<IEnumerable<Car>> GetAllCarsAsync()
		{
			return await _carRepository.GetAllAsync();
		}

		public async Task<Car> GetCarByIdAsync(string id)
		{
			return await _carRepository.GetByIdAsync(id);
		}

		public async Task AddCarAsync(Car car)
		{
			await _carRepository.AddAsync(car);
		}

		public async Task UpdateCarAsync(Car car)
		{
			await _carRepository.UpdateAsync(car);
		}

		public async Task DeleteCarAsync(string id)
		{
			await _carRepository.DeleteAsync(id);
		}
	}
}
