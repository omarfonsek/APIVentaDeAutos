using APIVentaDeAutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIVentaDeAutos.Domain.Interfaces
{
	public interface ICarRepository
	{
		Task<IEnumerable<Car>> GetAllAsync();
		Task<Car> GetByIdAsync(string id);
		Task AddAsync(Car car);
		Task UpdateAsync(Car car);
		Task DeleteAsync(string id);
	}
}
