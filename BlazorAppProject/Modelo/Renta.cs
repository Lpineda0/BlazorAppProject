using System.ComponentModel.DataAnnotations;

namespace BlazorAppProject.Modelo
{
	public class Renta
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "La fecha de renta del equipo es requerida")]
		public DateOnly? Fecha { get; set; }
		public int PersonaId { get; set; }
		public virtual Persona? Persona { get; set; }

		virtual public ICollection<Persona>? Personas { get; set; }
		virtual public ICollection<Equipo>? Equipos { get; set; }

	}
}