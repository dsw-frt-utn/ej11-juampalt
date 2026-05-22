using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno nuevoalumno)
    { 
        alumnos.Add(nuevoalumno);

    }

    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }

    public Alumno BusquedaAlumno(string nombre)
    {
      return alumnos.Find(a => a.Nombre == nombre);
        
    }


    public void BorradoAlumno(Alumno alumnoaborrar)
    {
       alumnos.Remove(alumnoaborrar);
    }


    public void BorradoAlumnoPorPosicion(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }


}

    
    

            







