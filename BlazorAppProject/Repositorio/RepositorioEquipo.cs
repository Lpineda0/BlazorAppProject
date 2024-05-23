using BlazorAppProject.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppProject.Repositorio
{
	public class RepositorioEquipo : IRepositorioEquipo
	{
		private readonly CatalogoDBContext _context;

		public RepositorioEquipo(CatalogoDBContext context)
		{
			_context = context;
		}

		public async Task<Equipo> Add(Equipo equipo)
		{
			await _context.Equipos.AddAsync(equipo);
			await _context.SaveChangesAsync();
			return equipo;
		}

		public async Task Delete(int id)
		{
			var equipo = await _context.Equipos.FindAsync(id);
			if (equipo != null)
			{
				_context.Equipos.Remove(equipo);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Equipo?> Get(int id)
		{
			return await _context.Equipos.FindAsync(id);
		}

		public async Task<List<Equipo>> GetAll()
		{
			return await _context.Equipos.ToListAsync();
		}

		public async Task<List<Persona>> GetPersona()
		{
			return await _context.Personas.ToListAsync();
		}

		public async Task Update(int id, Equipo equipo)
		{
			var equipoactual = await _context.Personas.FindAsync(id);
			if (equipoactual != null)
			{
				equipoactual.Nombre = equipo.Nombre;
				equipoactual.Equipo.Descripcion = equipo.Descripcion;
				await _context.SaveChangesAsync();
			}

		}
	}
}