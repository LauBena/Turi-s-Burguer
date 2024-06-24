using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Repartidor
{
    [Key]
    public int RepartidorId { get; set; }
    public string Nombre { get; set; }

    public ICollection<Pedido> Pedidos { get; set; }
    public ICollection<Cliente> Clientes { get; set; }
}