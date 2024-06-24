using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Cliente
{
    [Key]
    public int ClienteID { get; set; }
    public string? ClienteNombre { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }
    public string? Direccion { get; set; }

    public ICollection<Pedido> Pedidos { get; set; }
}