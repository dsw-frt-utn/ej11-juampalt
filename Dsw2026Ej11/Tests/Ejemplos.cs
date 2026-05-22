using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList controladorlist = new CasoList();
        Alumno a1 = new Alumno(01, "Juan", 8.5);
        Alumno a2 = new Alumno(02, "Francisco", 9.0);
        Alumno a3 = new Alumno(03, "Juan Fernando", 10.0);

        controladorlist.AgregarAlumno(a1);
        controladorlist.AgregarAlumno(a2);
        controladorlist.AgregarAlumno(a3);

        Console.WriteLine("Lista alumnos");
        foreach (var al in controladorlist.ObtenerLista())
        {
            Console.WriteLine($"Id alumno:{al.Id} - Nombre:{al.Nombre} - Promedio:{al.Promedio}");
        }
        Console.WriteLine();

        Console.WriteLine(" Buscando alumno que existe (Francisco) ");
        Alumno existe = controladorlist.BusquedaAlumno("Francisco");
        if (existe != null)
        {
            Console.WriteLine($"Encontrado ID: {existe.Id} - Nombre: {existe.Nombre}");
        }
        Console.WriteLine();


        Console.WriteLine("Busqueda de no existe(Pedro)");
        Alumno noexiste = controladorlist.BusquedaAlumno("Pedro");
        if (noexiste == null)
        {
            Console.WriteLine("El alumno no existe");
        }
        Console.WriteLine();

        Console.WriteLine("Borrar a Juan Fernando");
        controladorlist.BorradoAlumno(a3);
        foreach (var al in controladorlist.ObtenerLista())
        {
            Console.WriteLine($"id: {al.Id} - Nombre:{al.Nombre} - Promedio:{al.Promedio}");
        }
        Console.WriteLine();
        Console.WriteLine("Borrar primero");
        controladorlist.BorradoAlumnoPorPosicion(0);

        foreach (var al in controladorlist.ObtenerLista())
        {
            Console.WriteLine($"id: {al.Id} - Nombre:{al.Nombre} - Promedio:{al.Promedio}");
        }







    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary controladorDic = new CasoDictionary();
        Alumno a1 = new Alumno(01, "Juan", 8.5);
        Alumno a2 = new Alumno(02, "Francisco", 9.0);
        Alumno a3 = new Alumno(03, "Juan Fernando", 10.0);

        controladorDic.AgregarAlumno(a1);
        controladorDic.AgregarAlumno(a2);
        controladorDic.AgregarAlumno(a3);


        Console.WriteLine("Diccionario de alumnos");

        foreach (var alu in controladorDic.RetornarDic())
        {
            Console.WriteLine($"Legajo: {alu.Key} | id: {alu.Value.Id}| nombre: {alu.Value.Nombre} ");
        }
        Console.WriteLine();

        Console.WriteLine("Buscar por clave(01)");
        Alumno encontrado = controladorDic.BuscarAlumnoPorID(01);
        Console.WriteLine($"Encontrado: Nombre: {encontrado.Nombre}");
        Console.WriteLine();


        Console.WriteLine("Buscando alumno con clave 999 ");
        try
        {
            Alumno noencontrado = controladorDic.BuscarAlumnoPorID(999);
            Console.WriteLine($"Encontrado Nombre: {noencontrado.Nombre}");
        }
        catch (System.Collections.Generic.KeyNotFoundException)
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("Eliminando al alumno con clave 02");
        controladorDic.BorrarAlumno(02);

        foreach (var alu in controladorDic.RetornarDic())
        {
            Console.WriteLine($"Legajo: {alu.Key} | id: {alu.Value.Id}| nombre: {alu.Value.Nombre} ");
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq controladorLinq = new CasoLinq();

        Console.WriteLine("LINQ Pruebas");


        Console.WriteLine("Primer libro:");
        var primero = controladorLinq.GetPrimero();
        if (primero != null) Console.WriteLine($"Título: {primero.Titulo}");
        Console.WriteLine();


        Console.WriteLine("Último libro:");
        var ultimo = controladorLinq.GetUltimo();
        if (ultimo != null) Console.WriteLine($"Título: {ultimo.Titulo}");

        Console.WriteLine();


        Console.WriteLine("Suma total de precios:");
        Console.WriteLine($"Total: {controladorLinq.GetTotalPrecios():C}");
        Console.WriteLine();

        Console.WriteLine("Promedio de precios:");
        Console.WriteLine($"Promedio: {controladorLinq.GetPromedioPrecios():C}");

        Console.WriteLine();
        Console.WriteLine("Libros con ID mayor a 15:");
        foreach (var l in controladorLinq.GetListById())
        {
            Console.WriteLine($"ID: {l.Id} - Título: {l.Titulo}");
        }
        Console.WriteLine();

        Console.WriteLine("Lista de cada libro (Strings formateados):");
        foreach (var texto in controladorLinq.GetLibros())
        {
            Console.WriteLine(texto);
        }
        Console.WriteLine();

        Console.WriteLine("Libro con el precio más alto:");
        var mayor = controladorLinq.GetMayorPrecio();
        if (mayor != null) Console.WriteLine($"Título: {mayor.Titulo} - Precio: {mayor.Precio:C}");

        Console.WriteLine();
        Console.WriteLine("Libro con el precio más bajo:");
        var menor = controladorLinq.GetMenorPrecio();
        if (menor != null) Console.WriteLine($"Título: {menor.Titulo} - Precio: {menor.Precio:C}");

        Console.WriteLine();
        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (var l in controladorLinq.GetMayorPromedio())
        {
            Console.WriteLine($"Título: {l.Titulo} - Precio: {l.Precio:C}");
        }

        Console.WriteLine();
        Console.WriteLine("Libros ordenados por título (Descendente):");
        foreach (var l in controladorLinq.LibrosTitulos())
        {
            Console.WriteLine($"Título: {l.Titulo}");
        }



    }
}
