using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Stock
{
    [Key]
    public int StockId { get; set; }
    public int Cantidad { get; set; }
    public DateTime FechaIngreso { get; set; }

    public int ProductId { get; set; }
    public virtual Producto Producto { get; set; }
}