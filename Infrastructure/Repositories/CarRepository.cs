using APIVentaDeAutos.Domain.Entities;
using APIVentaDeAutos.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIVentaDeAutos.Infrastructure.Repositories
{
	public class CarRepository : ICarRepository
	{
		private readonly AppDbContext _context;

		public CarRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Car>> GetAllAsync()
		{
			return await _context.Cars.ToListAsync();
		}

		public async Task<Car> GetByIdAsync(string id)
		{
			return await _context.Cars.FindAsync(id);
		}

		public async Task AddAsync(Car car)
		{
			await _context.Cars.AddAsync(car);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Car car)
		{
			_context.Cars.Update(car);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(string id)
		{
			var car = await _context.Cars.FindAsync(id);
			if (car != null)
			{
				_context.Cars.Remove(car);
				await _context.SaveChangesAsync();
			}

		}
	}
}
