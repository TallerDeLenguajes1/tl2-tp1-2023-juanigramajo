
public class Cadete{
    private int ID;
    private string Nombre;
    private string Direccion:
    private int Telefono;
    private List<Pedido> ListadoPedidos;
    private int PedidosEntregados;


    public Cadete(int idCad, string name, string address, int phoneNumb){
        this.ID = idCad;
        this.Nombre = name;
        this.Direccion = address;
        this.Telefono = phoneNumb;
        this.ListadoPedidos = List<Pedido>();
        this.PedidosEntregados = 0;
    }

    public void JornalACobrar(){
        
        Console.WriteLine("\nTotal recaudado en el día: " + (this.PedidosEntregados * 500));
    }

    public void AsignarPedido(Pedido pedido){
        this.ListadoPedidos.Add(pedido);
    }

    private void ModificarPedido(int nro, string observ, string status){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.Nro == nro)
            {
                ped.Obs = name;
                ped.Estado = status;
                Console.WriteLine("Se modificó el pedido con éxito");
            }
        }
    }

    public void ListarPedidos(){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            Console.WriteLine($"\nPedido Nº[{ped.Nro}]");
            Console.WriteLine("\n" + ped.Obs);
            Console.WriteLine("\n" + ped.cliente.listarDatosCliente());
            Console.WriteLine("\n" + ped.Estado);
        }
    }
    
    public void FinalizarPedido(int nro){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.Nro == nro)
            {
                ped.Estado = "Entregado";
                this.PedidosEntregados++;
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("Se entregó el pedido con éxito");
            }
        }
    }

    public void EliminarPedidoSinEntregar(int nro){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.Nro == nro)
            {
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("Se eliminó el pedido con éxito");
            }
        }
    }
}

