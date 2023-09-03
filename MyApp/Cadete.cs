
public class Cadete{
    private int ID;
    private string Nombre;
    private string Direccion;
    private int Telefono;
    private List<Pedido> ListadoPedidos;
    private int PedidosEntregados;


    public Cadete(int idCad, string name, string address, int phoneNumb){
        this.ID = idCad;
        this.Nombre = name;
        this.Direccion = address;
        this.Telefono = phoneNumb;
        this.ListadoPedidos = new List<Pedido>();
        this.PedidosEntregados = 0;
    }

    public int getID(){

        return this.ID;
    }

    public string getNombre(){

        return this.Nombre;
    }
    
    public string getDireccion(){

        return this.Direccion;
    }

    public int getTelefono(){

        return this.Telefono;
    }

    public void JornalACobrar(){
        
        Console.WriteLine("\nTotal recaudado en el día: " + (this.PedidosEntregados * 500));
    }

    public void AsignarPedido(Pedido pedido){

        this.ListadoPedidos.Add(pedido);
    }

    public void AsignarPedido(int numPed){

        foreach (Pedido ped in this.ListadoPedidos)
            {
                if (ped.getNroPedido() == numPed)
                {
                    this.ListadoPedidos.Add(ped);
                }
            }
    }

    // private void ModificarPedido(int nro, string observ, string status){
    //     foreach (Pedido ped in this.ListadoPedidos)
    //     {
    //         if (ped.getNroPedido() == nro)
    //         {
    //             ped.Obs = observ;
    //             ped.Estado = status;
    //             Console.WriteLine("Se modificó el pedido con éxito");
    //         }
    //     }
    // }

    // public void ListarPedidos(){
    //     foreach (Pedido ped in this.ListadoPedidos)
    //     {
    //         Console.WriteLine($"\nPedido Nº[{ped.getNroPedido()}]");
    //         Console.WriteLine("\n" + ped.getObs());
    //         Console.WriteLine("\n" + ped.cliente.listarDatosCliente());
    //         Console.WriteLine("\n" + ped.getEstado());
    //     }
    // }
    
    public void FinalizarPedido(int nro){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getNroPedido() == nro)
            {
                this.PedidosEntregados++;
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("Se entregó el pedido con éxito");
            }
        }
    }

    public void EliminarPedidoSinEntregar(int nro){
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getNroPedido() == nro)
            {
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("Se eliminó el pedido con éxito");
            }
        }
    }
}

