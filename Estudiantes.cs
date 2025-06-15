// Estudiante.cs
using System;

namespace RegistroEstudiantes
{
    public class Estudiante
    {
        // Propiedades de la clase Estudiante
        public int Id { get; set; } // Identificador único del estudiante
        public string Nombres { get; set; } // Nombres del estudiante
        public string Apellidos { get; set; } // Apellidos del estudiante
        public string Direccion { get; set; } // Dirección de residencia del estudiante
        public string[] Telefonos { get; set; } // Array para almacenar hasta 3 números de teléfono

        // Constructor de la clase Estudiante
        // Permite inicializar un nuevo objeto Estudiante con todos sus datos
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;

            // Validar que el array de teléfonos no sea nulo y tenga un tamaño adecuado (máximo 3)
            if (telefonos != null && telefonos.Length <= 3)
            {
                Telefonos = new string[telefonos.Length]; // Inicializar el array con el tamaño correcto
                Array.Copy(telefonos, Telefonos, telefonos.Length); // Copiar los elementos al array
            }
            else
            {
                // Si los teléfonos son nulos o exceden el límite, inicializar un array vacío
                Console.WriteLine("Advertencia: El número de teléfonos excede el límite (3) o es nulo. Se inicializará con un array vacío.");
                Telefonos = new string[0];
            }
        }

        // Método para mostrar la información completa del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"--- Información del Estudiante (ID: {Id}) ---");
            Console.WriteLine($"Nombres Completos: {Nombres} {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.Write("Teléfonos: ");
            if (Telefonos != null && Telefonos.Length > 0)
            {
                // Iterar sobre el array de teléfonos para mostrarlos
                for (int i = 0; i < Telefonos.Length; i++)
                {
                    Console.Write($"{Telefonos[i]}");
                    if (i < Telefonos.Length - 1)
                    {
                        Console.Write(", "); // Separador entre números de teléfono
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se han registrado teléfonos.");
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}

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