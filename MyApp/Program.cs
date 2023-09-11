// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;


Cadeteria cadeteria = new Cadeteria();
CargaDeArchivos();


void CargaDeArchivos(){

    Console.WriteLine("\n\n----------CARGA DE ARCHIVOS----------\nOPCIONES:\n[1]: Cargar datos desde un archivo CSV\n[2]: Cargar datos desde un archivo JSON");
    int opcion = int.Parse(Console.ReadLine());
    while ((opcion < 1) || (opcion > 2))
    {
        Console.WriteLine($"\nError de formato.\nOPCIONES:\n[1]: Cargar datos desde un archivo CSV\n[2]: Cargar datos desde un archivo JSON");
        opcion = int.Parse(Console.ReadLine());
    }

    if (opcion == 1)
    {
        AccesoCSV accesoCSV = new AccesoCSV();

        Console.WriteLine("\nCargando datos de la cadeteria desde un archivo CSV...");

        cadeteria = accesoCSV.CargarDatosCadeteria();
        cadeteria.VerDatosCadeteria();

        Console.WriteLine("\n\nCargando datos de los cadetes...");
        
        accesoCSV.cargarDatosCadetes(cadeteria);
        cadeteria.MostrarCadetes();

    } else
    {
        AccesoJSON accesoJSON = new AccesoJSON();

        Console.WriteLine("\nCargando datos de la cadeteria desde un archivo JSON...");

        cadeteria = accesoJSON.CargarDatosCadeteria();
        cadeteria.VerDatosCadeteria();

        Console.WriteLine("\n\nCargando datos de los cadetes...");
        
        accesoJSON.cargarDatosCadetes(cadeteria);
        cadeteria.MostrarCadetes();
    }
}


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

cadeteria.ReasignarCadete(1, 3, 2);

cadeteria.MostrarPedidosDeCadetes(1);
cadeteria.MostrarPedidosDeCadetes(2);
cadeteria.MostrarPedidosDeCadetes(3);

cadeteria.FinalizarPedido(1);
cadeteria.FinalizarPedido(2);
cadeteria.JornalACobrar(3);
cadeteria.GenerarInforme();