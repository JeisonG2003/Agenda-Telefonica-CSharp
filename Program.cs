using System;

namespace AgendaTelefonica
{
    // En esta estructura agrupamos la información de cada contacto.
    // Decidimos usar struct porque los datos son simples y no necesitamos herencia.
    public struct Contacto
    {
        public string Nombre;
        public string Telefono;
        public string Correo;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Aquí creamos un vector para almacenar los contactos.
            // Definimos un tamaño fijo porque es suficiente para esta práctica.
            Contacto[] agenda = new Contacto[5];

            // Esta variable nos permite saber cuántos contactos hemos registrado.
            int contador = 0;

            // Variable para guardar la opción seleccionada en el menú
            int opcion;

            do
            {
                // Limpiamos la pantalla para que el menú se muestre de forma ordenada
                Console.Clear();
                Console.WriteLine("===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Opción para agregar un nuevo contacto a la agenda
                        if (contador < agenda.Length)
                        {
                            Console.Write("Ingrese el nombre: ");
                            agenda[contador].Nombre = Console.ReadLine();

                            Console.Write("Ingrese el teléfono: ");
                            agenda[contador].Telefono = Console.ReadLine();

                            Console.Write("Ingrese el correo: ");
                            agenda[contador].Correo = Console.ReadLine();

                            // Aumentamos el contador porque se agregó un nuevo contacto
                            contador++;

                            Console.WriteLine("Contacto agregado correctamente.");
                        }
                        else
                        {
                            // Este mensaje se muestra cuando el vector ya está lleno
                            Console.WriteLine("La agenda está llena. No se pueden agregar más contactos.");
                        }
                        break;

                    case 2:
                        // Opción para mostrar todos los contactos registrados
                        Console.WriteLine("=== LISTA DE CONTACTOS ===");

                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                            Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                            Console.WriteLine($"Correo: {agenda[i].Correo}");
                            Console.WriteLine("---------------------------");
                        }
                        break;

                    case 3:
                        // Opción para buscar un contacto por nombre
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscar = Console.ReadLine();

                        bool encontrado = false;

                        for (int i = 0; i < contador; i++)
                        {
                            // Comparamos el nombre ingresado con los nombres almacenados
                            if (agenda[i].Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Contacto encontrado:");
                                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                                Console.WriteLine($"Correo: {agenda[i].Correo}");

                                encontrado = true;
                                break;
                            }
                        }

                        // Si no se encuentra el contacto, mostramos un mensaje
                        if (!encontrado)
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }
                        break;

                    case 4:
                        // Opción para salir del sistema
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        // Mensaje para opciones no válidas
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                // Pausamos la ejecución para que el usuario pueda leer el resultado
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
