
public class Pedido
{
    private int Nro;
    private string Obs;
    private Cliente cliente;
    private string Estado;

    public Pedido(){
    }

    public Pedido(int number, string observ, string status, string name, string address, int phoneNumb, string addressReferences){
        this.Nro = number;
        this.Obs = observ;
        this.cliente = new Cliente(name, address, phoneNumb, addressReferences);
        this.Estado = status;
    }

    public int getNroPedido(){

        return this.Nro;
    }

    public string getObs(){
        
        return this.Obs;
    }

    public string getEstado(){
        
        return this.Estado;
    }

    public void listarPedido(){
        Console.WriteLine($"\nPedido Nº[{this.Nro}]");
        Console.WriteLine($"Observación: " + this.Obs);
        Console.WriteLine($"Nombre del cliente: " + this.cliente.GetNombre());
        Console.WriteLine($"Estado: " + this.Estado);
    }

    public void VerDireccionCliente(){
        Console.WriteLine("La dirección del cliente es: " + this.cliente.GetDireccion());
        Console.WriteLine(this.cliente.GetDatosReferenciaDireccion());
    }

    public void VerDatosCliente(){
        Console.WriteLine("\nDatos del cliente:\n");
        Console.WriteLine("Nombre: " + this.cliente.GetNombre());
        Console.WriteLine("Direccion: " + this.cliente.GetDireccion());
        Console.WriteLine("Telefono: " + this.cliente.GetTelefono());
        Console.WriteLine("Datos de referencia de la direccion: " + this.cliente.GetDatosReferenciaDireccion());
    }
}