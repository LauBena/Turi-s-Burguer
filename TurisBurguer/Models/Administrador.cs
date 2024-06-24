using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Administrador
{
    [Key]
    public int AdministradorId { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }

    //buscar manera de hacer una visualizacion de las ventas

    public ICollection<Producto> Productos { get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
}