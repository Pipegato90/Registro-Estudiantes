
// Program.cs
using System;

namespace RegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Aplicación de Registro de Estudiantes ---");

            // Crear un array de teléfonos para el estudiante
            string[] telefonosEstudiante1 = { "0991234567", "022987654" };

            // Crear una instancia de la clase Estudiante
            Estudiante estudiante1 = new Estudiante(
                1001,
                "Ana",
                "García López",
                "Av. Amazonas N23-45 y La Gasca",
                telefonosEstudiante1
            );

            // Mostrar la información del estudiante
            estudiante1.MostrarInformacion();

            // Ejemplo de otro estudiante con 3 teléfonos
            string[] telefonosEstudiante2 = { "0987654321", "022123456", "0990001112" };
            Estudiante estudiante2 = new Estudiante(
                1002,
                "Luis",
                "Pérez Rodríguez",
                "Calle Los Sauces E1-23 y Las Flores",
                telefonosEstudiante2
            );
            estudiante2.MostrarInformacion();

            // Ejemplo de estudiante sin teléfonos
            Estudiante estudiante3 = new Estudiante(
                1003,
                "María",
                "Fernández Díaz",
                "Urbanización El Condado Casa #5",
                new string[0] // O pasar null si la validación del constructor lo maneja
            );
            estudiante3.MostrarInformacion();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}