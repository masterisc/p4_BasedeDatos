using System;

namespace BasedeDatos
{
	class BaseDeDatos
		
	{
		public BaseDeDatos(){
			
		}
			bool salir= false;
			
			
		public void menu()
        {
		
            Contacto contacto = new Contacto();
            int opcion;
            string id, nombre, telefono;
            
            Console.Write("\n1.- Ver todos los contactos"+
                "\n2.- Agregar contacto"+
                "\n3.- Editar contacto"+
                "\n4.- Eliminar contacto"+
                "\n5.- Salir"+
                "\n\n\n\tElige una opcion: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: contacto.mostrarTodos();
                        break;
                    case 2: Console.Write("nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("telefono: ");
                        telefono = Console.ReadLine();
                        contacto.insertarRegistroNuevo(nombre, telefono);
                        break;
                    case 3: Console.Write("id: ");
                        id = Console.ReadLine();
                        if (contacto.consultaId(id).Length > 0)
                        {
                            Console.Write("nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("telefono: ");
                            telefono = Console.ReadLine();
                            contacto.editarRegistro(id, nombre, telefono);
                        }
                        else
                            Console.WriteLine("El id no existe");
                        break;
                    case 4: Console.Write("id: ");
                        id = Console.ReadLine();
                        if (contacto.consultaId(id).Length > 0)
                        {
                            Console.WriteLine("Contacto eliminado");
                            contacto.eliminarRegistroPorId(id);
                        }
                        else
                            Console.WriteLine("El id no existe");
                        break;
                    case 5: Console.WriteLine("Gracias por utilizar el programa!!!");
                        salir = true;
                        break;
                    default: Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ingresa un entero");
            }

        }


        static void Main(string[] args)
        {
            
            Console.Title = "Base de datos";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            BaseDeDatos principal = new BaseDeDatos();
            do
            {
                Console.Clear();
                principal.menu();
                Console.ReadKey();
            } while (!principal.salir);
        }
	}
}