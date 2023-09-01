

public class Cliente{
    private string Nombre;
    private string Direccion;
    private int Telefono;
    private string DatosReferenciaDireccion;


    public Cliente(string name, string address, int phoneNumb, string addressReferences){
        this.Nombre = name;
        this.Direccion = address;
        this.Telefono = phoneNumb;
        this.DatosReferenciaDireccion = addressReferences;
    }

    public string GetNombre(){

        return this.Nombre;
    }

    public string GetDireccion(){

        return this.Direccion;
    }

    public int GetTelefono(){

        return this.Telefono;
    }

    public string GetDatosReferenciaDireccion(){

        return this.DatosReferenciaDireccion;
    }

    public void ListarDatosCliente(){
        Console.WriteLine("Nombre: " + this.Nombre);
        Console.WriteLine("Nombre: " + this.Direccion);
        Console.WriteLine("Nombre: " + this.Telefono);
        Console.WriteLine("Nombre: " + this.DatosReferenciaDireccion);
    }
}