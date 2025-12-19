using System;

namespace AgendaTelefonica
{
    // Esta clase se encarga de gestionar la agenda telefónica.
    // Aquí concentramos la lógica del negocio.
    public class Agenda
    {
        private Contacto[] contactos;
        private int contador;

        // Constructor: inicializa el vector de contactos
        public Agenda(int tamaño)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        // Método para agregar un nuevo contacto
        public void AgregarContacto()
        {
            if (contador < contactos.Length)
            {
                Console.Write("Ingrese el nombre: ");
                contactos[contador].Nombre = Console.ReadLine();

                Console.Write("Ingrese el teléfono: ");
                contactos[contador].Telefono = Console.ReadLine();

                Console.Write("Ingrese el correo: ");
                contactos[contador].Correo = Console.ReadLine();

                contador++;
                Console.WriteLine("Contacto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("La agenda está llena. No se pueden agregar más contactos.");
            }
        }

        // Método para mostrar todos los contactos
        public void MostrarContactos()
        {
            Console.WriteLine("=== LISTA DE CONTACTOS ===");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                Console.WriteLine($"Correo: {contactos[i].Correo}");
                Console.WriteLine("---------------------------");
            }
        }

        // Método para buscar un contacto por nombre
        public void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contacto encontrado:");
                    Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                    Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                    Console.WriteLine($"Correo: {contactos[i].Correo}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
