// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.IO;


Console.WriteLine("\nCargando datos de la cadeteria...");

Cadeteria cadeteria = cargarDatosCadeterias();
cadeteria.VerDatosCadeteria();

Console.WriteLine("\n\nCargando datos de los cadetes...");

cargarDatosCadetes(cadeteria);
cadeteria.MostrarCadetes();




cadeteria.TomarPedido(1, "Pizza especial", "En preparación", "Juan Ignacio", "Gral Paz 445", 381664663, "Gral entre chac. y bsas.");
cadeteria.TomarPedido(2, "Pizza común", "En preparación", "Diana", "BSAS 500", 381773782, "Entre gral y las piedras");
cadeteria.TomarPedido(3, "Sanguche JYQ", "En preparación", "Nico", "Juan B Justo 20", 381119283, "Esquina Avellaneda");
cadeteria.TomarPedido(4, "Sanguche milanesa", "En preparación", "Tiziano", "Avellaneda 300", 381774635, "Pasando el drugstore");

cadeteria.MostrarPedidosDeCadetes(1);
cadeteria.MostrarPedidosDeCadetes(2);
cadeteria.MostrarPedidosDeCadetes(3);

cadeteria.AsignarCadeteAPedido(1, 2);
cadeteria.AsignarCadeteAPedido(2, 3);
cadeteria.AsignarCadeteAPedido(3, 1);
cadeteria.AsignarCadeteAPedido(2, 4);

cadeteria.MostrarPedidosDeCadetes(1);
cadeteria.MostrarPedidosDeCadetes(2);
cadeteria.MostrarPedidosDeCadetes(3);

cadeteria.ReasignarCadete(1, 2, 3);

cadeteria.MostrarPedidosDeCadetes(1);
cadeteria.MostrarPedidosDeCadetes(2);
cadeteria.MostrarPedidosDeCadetes(3);

cadeteria.FinalizarPedido(1);
cadeteria.FinalizarPedido(2);
cadeteria.JornalACobrar(3);
cadeteria.GenerarInforme();


Cadeteria cargarDatosCadeterias(){

    string filePath = "datosCadeteria.csv";
    Cadeteria cadeteria = new Cadeteria();
        
    try
    {
        // Lee todas las líneas del archivo CSV.
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] fields = line.Split(',');

            // Accede a los datos de cada columna según su posición.
            string columna1 = fields[0];
            string columna2 = fields[1];

            cadeteria = new Cadeteria(columna1, int.Parse(columna2));
        }
    }
    catch (IOException e)
    {
        Console.WriteLine($"Error al leer el archivo: {e.Message}");
    }

    return cadeteria;
}

void cargarDatosCadetes(Cadeteria cadeteria){

    string filePath = "datosCadetes.csv"; // Reemplaza con la ruta de tu archivo CSV.
        
    try
    {
        // Lee todas las líneas del archivo CSV.
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] fields = line.Split(',');

            // Accede a los datos de cada columna según su posición.
            string columna1 = fields[0];
            string columna2 = fields[1];
            string columna3 = fields[2];
            string columna4 = fields[3];

            Cadete cadete = new Cadete(int.Parse(columna1), columna2, columna3, int.Parse(columna4));
            cadeteria.AñadirCadete(cadete);
        }
    }
    catch (IOException e)
    {
        Console.WriteLine($"Error al leer el archivo: {e.Message}");
    }
}
