
public class Cadete{
    private int ID;
    private string Nombre;
    private string Direccion;
    private int Telefono;
    private int PedidosEntregados;


    public Cadete(int idCad, string name, string address, int phoneNumb){
        this.ID = idCad;
        this.Nombre = name;
        this.Direccion = address;
        this.Telefono = phoneNumb;
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

    public void SumarEntrega(){
        this.PedidosEntregados = this.PedidosEntregados + 1;
    }
}

