
public class Cadeteria
{
    private string Nombre;
    private int Telefono;
    private List<Cadete> ListadoCadetes;


    public Cadeteria(){
    }
    public Cadeteria(string name, int phoneNumb){
        this.Nombre = name;
        this.Telefono = phoneNumb;
        this.ListadoCadetes = new List<Cadete>();
    }

    public void VerDatosCadeteria(){
        Console.WriteLine("\nNombre: " + this.Nombre);
        Console.WriteLine("Telefono: " + this.Telefono);
    }

    public void mostrarCadetes(){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            System.Console.WriteLine($"Cadete [{cad.getID()}]");
            System.Console.WriteLine($"Nombre: " + cad.getNombre());
            System.Console.WriteLine($"Dirección: " + cad.getDireccion());
            System.Console.WriteLine($"Telefono: " + cad.getTelefono());

        }
    }

    public void TomarPedido(int num, string observ, string status, string name, string address, int phoneNumb, string addressReferences){
        Pedido pedido = new Pedido(num, observ, status, name, address, phoneNumb, addressReferences);
        
        Random rnd = new Random();
        int idCadeteAsignado = rnd.Next(1, this.ListadoCadetes.Count);

        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == idCadeteAsignado)
            {
                cad.AsignarPedido(pedido);
            }
        }
    }

    public void ReasignarCadete(int nroPedido, int idCadete){

        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == idCadete)
            {
                cad.EliminarPedidoSinEntregar(nroPedido);
            }
        }

        Random rnd = new Random();
        int idCadeteAsignado = rnd.Next(1, this.ListadoCadetes.Count);
        
        while (idCadeteAsignado == idCadete)
        {
            idCadeteAsignado = rnd.Next(1, this.ListadoCadetes.Count);
        }

        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == idCadeteAsignado)
            {
                cad.AsignarPedido(nroPedido);
            }
        }
    }

    public void AñadirCadete(Cadete cadete){
        this.ListadoCadetes.Add(cadete);
    }

    public void EliminarCadete(int id){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == id)
            {
                this.ListadoCadetes.Remove(cad);
                Console.WriteLine("Se eliminó el cadete con éxito");
            }
        }
    }

    // public void ModificarCadete(int id, string name, string address, int phoneNumb){
    //     foreach (Cadete cad in this.ListadoCadetes)
    //     {
    //         if (cad.getID == id)
    //         {
    //             cad.ID = id;
    //             cad.Nombre = name;
    //             cad.Direccion = address;
    //             cad.Telefono = phoneNumb;
    //             Console.WriteLine("Se modificó el cadete con éxito");
    //         }
    //     }
    // }
}