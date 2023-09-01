
public class Cadeteria
{
    private string Nombre;
    private int Telefono;
    private List<Cadete> ListadoCadetes;


    public Cadeteria(string name, int phoneNumb){
        this.Nombre = name;
        this.Telefono = phoneNumb;
        this.ListadoCadetes = List<Cadete>();
    }

    public void TomarPedido(int num, string observ, Cliente client, string status, string name, string address, int phoneNumb, string addressReferences){
        Pedido pedido = new Pedido(num, observ, cliente, status);
        
        Random rnd = new Random();
        idCadeteAsignado = rnd.Next(1, this.ListadoCadetes.Count);

        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.ID == idCadeteAsignado)
            {
                cad.asignarPedido(pedido);
            }
        }
    }

    public void ReasignarCadete(int nroPedido, int idCadete){

        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.ID == idCadete)
            {
                cad.EliminarPedidoSinEntregar(nroPedido);
            }
        }

        do
        {
            Random rnd = new Random();
            idCadeteAsignado = rnd.Next(1, this.ListadoCadetes.Count);

            foreach (Cadete cad in this.ListadoCadetes)
            {
                if (cad.ID == idCadeteAsignado)
                {
                    cad.asignarPedido(pedido);
                }
            }
        
        } while (idCadeteAsignado == idCadete);
    }

    public void AñadirCadete(int id, string name, string address, int phoneNumb){
        Cadete cadete = new Cadete(id, name, address, phoneNumb)
        this.ListadoCadetes.Add(cadete);
    }

    public void EliminarCadete(int id){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.ID == id)
            {
                this.ListadoCadetes.Remove(cad);
                Console.WriteLine("Se eliminó el cadete con éxito");
            }
        }
    }

    public void ModificarCadete(int id, string name, string address, int phoneNumb){
        foreach (Cadete cad in this.ListadoCadetes)
        {
            if (cad.ID == id)
            {
                cad.ID = id;
                cad.Nombre = name;
                cad.Direccion = address;
                cad.Telefono = phoneNumb;
                Console.WriteLine("Se modificó el cadete con éxito");
            }
        }
    }
}