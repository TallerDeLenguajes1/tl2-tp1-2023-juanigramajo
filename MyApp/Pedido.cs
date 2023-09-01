
public class Pedido
{
    private int Nro;
    private string Obs;
    private Cliente cliente;
    private string Estado;


    public Pedido(int number, string observ, string status, string name, string address, int phoneNumb, string addressReferences){
        this.Nro = number;
        this.Obs = observ;
        this.cliente = new Cliente(name, address, phoneNumb, addressReferences);
        this.Estado = status;
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