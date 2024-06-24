using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurisBurguer.Models;

public class Pedido
{
    [Key]
    public int PedidoId { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaPedido { get; set; }
    public Estado Estado { get; set; }


    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }

    public int AdministratorId { get; set; }
    public virtual Administrador Administrador { get; set; }

    public int RepartidorId { get; set; }
    public virtual Repartidor Repartidor { get; set; }

    public ICollection<Producto> Productos { get; set; }
}

public enum Estado
{
    Pendiente = 1,
    Enpreparacion,
    Entregado
}