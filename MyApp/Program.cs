// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.IO;


Console.WriteLine("\nCargando datos de la cadeteria...");

Cadeteria cadeteria = cargarDatosCadeterias();
cadeteria.VerDatosCadeteria();


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

/* void cargarDatosCadetes(){

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
        }
    }
    catch (IOException e)
    {
        Console.WriteLine($"Error al leer el archivo: {e.Message}");
    }
}
*/