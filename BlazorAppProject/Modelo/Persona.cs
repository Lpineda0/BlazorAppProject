using System.ComponentModel.DataAnnotations;

namespace BlazorAppProject.Modelo
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
		[Required(ErrorMessage = "El telefono es requerido")]
		[StringLength(100, ErrorMessage = "Maximo 10 caracteres")]
		public string? Telefono { get; set; }
		
        
        [Required(ErrorMessage = "El equipo a rentar es requerido")]
        public int EquipoId { get; set; }
        public virtual Equipo? Equipo { get; set; }


	}
}
