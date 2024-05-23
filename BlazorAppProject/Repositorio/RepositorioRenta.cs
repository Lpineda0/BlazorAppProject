using BlazorAppProject.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppProject.Repositorio
{
	public class RepositorioRenta : IRepositorioRenta
	{
		private readonly CatalogoDBContext _context;

		public RepositorioRenta(CatalogoDBContext context)
		{
			_context = context;
		}

		public async Task<Renta> Add(Renta renta)
		{
			await _context.Rentas.AddAsync(renta);
			await _context.SaveChangesAsync();
			return renta;
		}

		public async Task Delete(int id)
		{
			var renta = await _context.Rentas.FindAsync(id);
			if (renta != null)
			{
				_context.Rentas.Remove(renta);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Renta?> Get(int id)
		{
			return await _context.Rentas.FindAsync(id);
		}

		public async Task<List<Renta>> GetAll()
		{
			return await _context.Rentas.ToListAsync();
		}
        
		public async Task<List<Persona>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }
		public async Task<Persona?> GetPersona(int id)
		{
			return await _context.Personas.FindAsync(id);
		}

		public async Task<List<Equipo>> GetEquipo()
        {
            return await _context.Equipos.ToListAsync();
        }
        public async Task Update(int id, Renta renta)
		{
			var rentaactual = await _context.Rentas.FindAsync(id);
			if (rentaactual != null)
			{
                rentaactual.Fecha = renta.Fecha;
                await _context.SaveChangesAsync();
			}

		}
	}
}