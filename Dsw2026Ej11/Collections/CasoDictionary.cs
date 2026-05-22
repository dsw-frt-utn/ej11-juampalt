using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> diccionario = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        diccionario.Add(alumno.Id, alumno);
    }

    public Alumno BuscarAlumnoPorID(int legajo)
    {
        return diccionario[legajo];
    }

    public Dictionary<int, Alumno> RetornarDic()
    {
        return diccionario;
    }

    public void BorrarAlumno(int legajo)
    {
        diccionario.Remove(legajo);
    }
}
