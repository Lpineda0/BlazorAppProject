using BlazorAppProject.Modelo;

namespace BlazorAppProject.Repositorio
{
	public interface IRepositorioRenta
	{
		Task<List<Renta>> GetAll();
		Task<Renta?> Get(int id);
		Task<Renta> Add(Renta renta);
		Task Update(int id, Renta renta);
		Task Delete(int id);

		Task<List<Equipo>> GetEquipo();
		Task<List<Persona>> GetPersona();
	}
}
