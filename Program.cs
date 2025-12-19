using System;

namespace AgendaTelefonica
{
    // Esta clase contiene el punto de entrada del programa.
    // Aquí nos encargamos únicamente de la interacción con el usuario
    // mediante un menú y de llamar a los métodos de la clase Agenda.
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto de la clase Agenda con un tamaño máximo de 5 contactos.
            // De esta forma delegamos la gestión de los datos a otra clase.
            Agenda agenda = new Agenda(5);

            // Variable que utilizamos para almacenar la opción seleccionada en el menú.
            int opcion;

            do
            {
                // Limpiamos la consola para mostrar el menú de forma ordenada.
                Console.Clear();
                Console.WriteLine("===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Leemos la opción ingresada por el usuario.
                opcion = int.Parse(Console.ReadLine());

                // Según la opción elegida, llamamos al método correspondiente
                // de la clase Agenda.
                switch (opcion)
                {
                    case 1:
                        // Llamamos al método que permite agregar un nuevo contacto.
                        agenda.AgregarContacto();
                        break;

                    case 2:
                        // Llamamos al método que muestra todos los contactos registrados.
                        agenda.MostrarContactos();
                        break;

                    case 3:
                        // Llamamos al método que permite buscar un contacto por nombre.
                        agenda.BuscarContacto();
                        break;

                    case 4:
                        // Mensaje que se muestra cuando el usuario decide salir del sistema.
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        // Mensaje que se muestra cuando se ingresa una opción no válida.
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                // Pausamos la ejecución para que el usuario pueda leer el resultado
                // antes de volver a mostrar el menú.
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}

