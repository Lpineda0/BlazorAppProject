using BlazorAppProject.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppProject.Repositorio
{
	public class RepositorioPersonas : IRepositorioPersonas
	{
		private readonly CatalogoDBContext _context;
		
		public RepositorioPersonas(CatalogoDBContext context)
		{
			_context = context;
		}

		public async Task<Persona> Add(Persona persona)
		{
			await _context.Personas.AddAsync(persona);
			await _context.SaveChangesAsync();
			return persona;
		}

		public async Task Delete(int id)
		{
			var persona = await _context.Personas.FindAsync(id);
			if (persona != null)
			{
				_context.Personas.Remove(persona);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Persona?> Get(int id)
		{
			return await _context.Personas.FindAsync(id);
		}

		public async Task<List<Persona>> GetAll()
		{
			return await _context.Personas.ToListAsync();
		}

		public async Task<List<Equipo>> GetEquipo()
		{
			return await _context.Equipos.ToListAsync();
		}

		public async Task Update(int id, Persona persona)
		{
			var personaactual = await _context.Personas.FindAsync(id);
			if (personaactual != null)
			{
				personaactual.Nombre = persona.Nombre;
				personaactual.EquipoId = persona.EquipoId;
				personaactual.Telefono = persona.Telefono;
				await _context.SaveChangesAsync();
			}
				
		}
	}
}
