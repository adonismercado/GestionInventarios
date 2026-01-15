using System.ComponentModel.DataAnnotations;

namespace AP1GestionInventario.Models
{
    public class Entrada
    {
        [Key]
        public int EntradaId { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El concepto es obligatorio")]
        [StringLength(300)]
        public string Concepto { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public ICollection<EntradaDetalle> EntradaDetalles { get; set; } = new List<EntradaDetalle>();
    }
}
