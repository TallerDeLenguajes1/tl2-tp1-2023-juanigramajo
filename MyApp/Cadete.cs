
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

    public int getPedEntregados(){

        return this.PedidosEntregados;
    }

    public void ListarPedidos(){

        if (this.ListadoPedidos.Any())
        {
            Console.WriteLine($"\n--------------------------");
            Console.WriteLine($"Cadete ID[{this.ID}]");
        }

        foreach (Pedido ped in this.ListadoPedidos)
        {            
            ped.listarPedido();
        }
    }
    
    public int JornalACobrar(){
        
        return this.PedidosEntregados * 500;
    }

    public Pedido devolverTalPedido(int nroPedido){

        Pedido pedid = new Pedido();
        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getNroPedido() == nroPedido)
            {
                pedid = ped;
            }
        }
        
        return pedid;
    }
    
    public void AsignarPedido(Pedido pedido){

        this.ListadoPedidos.Add(pedido);
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

        for (int i = 0; i < this.ListadoPedidos.Count; i++)
        {
            Pedido ped = this.ListadoPedidos[i];
            if (ped.getNroPedido() == nro)
            {
                this.PedidosEntregados++;
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("\nSe entregó el pedido con éxito");
                // Resta 1 a i para compensar el desplazamiento después de eliminar un elemento
                i--;
            }
        }
    }

    public void EliminarPedidoSinEntregar(int nro)
    {
        for (int i = 0; i < this.ListadoPedidos.Count; i++)
        {
            Pedido ped = this.ListadoPedidos[i];
            if (ped.getNroPedido() == nro)
            {
                this.ListadoPedidos.Remove(ped);
                Console.WriteLine("\nSe eliminó el pedido con éxito");
                // Resta 1 a i para compensar el desplazamiento después de eliminar un elemento
                i--;
            }
        }
    }
}

