
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

    public void MostrarCadetes(){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            Console.WriteLine($"\nCadete [{cad.getID()}]");
            Console.WriteLine($"Nombre: " + cad.getNombre());
            Console.WriteLine($"Dirección: " + cad.getDireccion());
            Console.WriteLine($"Telefono: " + cad.getTelefono());
        }
    }

    public void FinalizarPedido(int cadeteID, int nroPed){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == cadeteID)
            {
                cad.FinalizarPedido(nroPed);
            }
        }
    }

    public void GananciasPorCadete(int cadeteID){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == cadeteID)
            {
                Console.WriteLine($"\nCadete Nº[{cad.getID()}]");
                Console.WriteLine("\nTotal recaudado en el día: " + cad.JornalACobrar());
            }
        }
    }

    public void GenerarInforme(){
        int total = 0;
        foreach (Cadete cad in this.ListadoCadetes)
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"\nCadete Nº[{cad.getID()}]");
            Console.WriteLine("\nCantidad de envios en el día: " + cad.getPedEntregados());
            Console.WriteLine("\nTotal recaudado en el día: " + cad.JornalACobrar());
            total = total + cad.JornalACobrar();
        }
        Console.WriteLine("\n\n\nTotal ganado en el día por la cadetería: " + total);
    }

    public void MostrarPedidosDeCadetes(){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            cad.ListarPedidos();
        }
    }

    public void MostrarPedidosDeCadetes(int idCadete){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == idCadete)
            {
                cad.ListarPedidos();
            }
        }
    }

    public void TomarPedido(int num, string observ, string status, string name, string address, int phoneNumb, string addressReferences, int cadeteID){
        Pedido pedido = new Pedido(num, observ, status, name, address, phoneNumb, addressReferences);
        
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == cadeteID)
            {
                cad.AsignarPedido(pedido);
            }
        }
    }

    public void ReasignarCadete(int nroPedido, int idCadeteActual, int idCadeteNuevo){
        
        Pedido pedid = new Pedido();
        
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == idCadeteActual)
            {
                // Busco el pedido para ser reasignado
                pedid = cad.devolverTalPedido(nroPedido);

                // Busco el cadete y le asigno el pedido
                foreach (Cadete cade in this.ListadoCadetes)
                {
                    if (cade.getID() == idCadeteNuevo)
                    {
                        cade.AsignarPedido(pedid);
                    }
                }

                // Elimino el pedido del listado de pedidos del cadete
                cad.EliminarPedidoSinEntregar(nroPedido);
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