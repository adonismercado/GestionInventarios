using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AP1GestionInventario.Models;

public class EntradaDetalle
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int EntradaId { get; set; }

    [ForeignKey("EntradaId")]
    public Entrada? Entrada { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un producto")]
    public int ProductoId { get; set; }

    [ForeignKey("ProductoId")]
    public Producto? Producto { get; set; }

    [Required(ErrorMessage = "La cantidad es obligatoria")]
    [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "El costo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El costo debe ser mayor a 0")]
    public decimal Costo { get; set; }

    [NotMapped]
    public decimal Subtotal => Cantidad * Costo;
}
