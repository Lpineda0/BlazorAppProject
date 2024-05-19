using BlazorAppProject.Modelo;

namespace BlazorAppProject.Repositorio
{
	public interface IRepositorioEquipo
	{
		Task<List<Equipo>> GetAll();
		Task<Equipo?> Get(int id);
		Task<List<Persona>> GetPersona();
		Task<Equipo> Add(Equipo equipo);
		Task Update(int id, Equipo equipo);
		Task Delete(int id);
	}
}
