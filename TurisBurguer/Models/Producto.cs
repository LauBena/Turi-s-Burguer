using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Producto
{
    [Key]
    public int ProductoId { get; set; }
    public string Tipo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public byte[] Imagen { get; set; }

    public virtual Stock Stock { get; set; }

    public int AdministradorId { get; set; }
    public virtual Administrador Administrador { get; set; }
}