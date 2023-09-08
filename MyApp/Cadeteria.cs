
public class Cadeteria
{
    private string Nombre;
    private int Telefono;
    private List<Cadete> ListadoCadetes;
    private List<Pedido> ListadoPedidos;


    public Cadeteria(){
    }

    public Cadeteria(string name, int phoneNumb){
        this.Nombre = name;
        this.Telefono = phoneNumb;
        this.ListadoCadetes = new List<Cadete>();
        this.ListadoPedidos = new List<Pedido>();
    }

    public void TomarPedido(int num, string observ, string status, string name, string address, int phoneNumb, string addressReferences){
        Pedido pedido = new Pedido(num, observ, status, name, address, phoneNumb, addressReferences);
        ListadoPedidos.Add(pedido);
    }
    
    public void ListarPedidos(){

        foreach (Pedido ped in this.ListadoPedidos)
        {            
            Console.WriteLine($"\n--------------------------");
            ped.ListarPedido();
        }
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

    public int JornalACobrar(int cadeteID){
        int jornal = 0;
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.getID() == cadeteID)
            {
                jornal = (cad.getPedEntregados() * 500);
            }
        }
    
        return jornal;
    }

    public void GenerarInforme(){
        int total = 0;
        foreach (Cadete cad in this.ListadoCadetes)
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"\nCadete Nº[{cad.getID()}]");
            Console.WriteLine("\nCantidad de envios en el día: " + cad.getPedEntregados());
            Console.WriteLine("\nTotal recaudado en el día: " + this.JornalACobrar(cad.getID()));
            total = total + this.JornalACobrar(cad.getID());
        }
        Console.WriteLine("\n\n\nTotal ganado en el día por la cadetería: " + total);
    }

    // public void MostrarPedidosDeCadetes(){
    //     foreach (Cadete cad in this.ListadoCadetes)
    //     {
    //         cad.ListarPedidos();
    //     }
    // }

    public void MostrarPedidosDeCadetes(int idCadete){

        System.Console.WriteLine($"\nEl cadete Nº[{idCadete}] aún no posee pedidos para entregar");
        Console.WriteLine($"\nCadete Nº[{idCadete}]");

        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getIDCadete() == idCadete)
            {
                ped.ListarPedido();
            }
        }
    }

    public void AsignarCadeteAPedido(int cadeteID, int nroPed){

        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getNroPedido() == nroPed)
            {
                foreach (Cadete cad in this.ListadoCadetes)
                {
                    if (cad.getID() == cadeteID)
                    {
                        ped.AsignarCadete(cad);
                        Console.WriteLine($"\nPedido Nº[{nroPed}] asignado con éxito al cadete Nº[{cadeteID}]");
                    }
                }
            }
        }
    }

    // public void ReasignarCadete(int nroPedido, int idCadeteActual, int idCadeteNuevo){
        
    //     Pedido pedid = new Pedido();
        
    //     foreach (Cadete cad in this.ListadoCadetes)
    //     {
    //         if (cad.getID() == idCadeteActual)
    //         {
    //             // Busco el pedido para ser reasignado
    //             pedid = cad.devolverTalPedido(nroPedido);

    //             // Busco el cadete y le asigno el pedido
    //             foreach (Cadete cade in this.ListadoCadetes)
    //             {
    //                 if (cade.getID() == idCadeteNuevo)
    //                 {
    //                     cade.AsignarPedido(pedid);
    //                 }
    //             }

    //             // Elimino el pedido del listado de pedidos del cadete
    //             cad.EliminarPedidoSinEntregar(nroPedido);
    //         }
    //     }
    // }

    public void ReasignarCadete(int nroPedido, int idCadeteActual, int idCadeteNuevo){

        foreach (Pedido ped in this.ListadoPedidos)
        {
            if (ped.getIDCadete() == idCadeteActual)
            {
                foreach (Cadete cad in this.ListadoCadetes)
                {
                    if (cad.getID() == idCadeteNuevo)
                    {
                        ped.AsignarCadete(cad);
                    }
                }
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
    
    public void FinalizarPedido(int nro){

        for (int i = 0; i < this.ListadoPedidos.Count; i++)
        {
            Pedido ped = this.ListadoPedidos[i];
            if (ped.getNroPedido() == nro)
            {
                foreach (Cadete cad in this.ListadoCadetes)
                {
                    if (cad.getID() == ped.getIDCadete())
                    {
                        cad.SumarEntrega();
                    }
                }
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