using System.ComponentModel.DataAnnotations;

namespace BlazorAppProject.Modelo
{
	public class Equipo
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El nombre del equipo a rentar es requerido")]
		[StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
		public string? Nombre { get; set; }
		[Required(ErrorMessage = "La descripción del equipo es requerida")]
		[StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
		public string? Descripcion { get; set; }

		virtual public ICollection<Persona>? Personas { get; set; }

	}
}