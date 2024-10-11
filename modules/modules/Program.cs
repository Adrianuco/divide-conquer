namespace modules
{
    public class Estudiante
    {
        public int id { get; set; }
        public string nombre { get; set; }

        // Constructor
        public Estudiante(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        // Método para mostrar detalles
        public void MostrarDetalles()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}");
        }
    }

    public class Asignatura
    {
        public int codigo { get; set; }
        public string nombre { get; set; }

        // Constructor
        public Asignatura(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        // Método para mostrar detalles
        public void MostrarAsignatura()
        {
            Console.WriteLine($"Código: {codigo}, Nombre: {nombre}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            List<Asignatura> asignaturas = new List<Asignatura>();

            string opcion = "";
            while (opcion != "0")
            {
                Console.Clear(); // Limpia la consola antes de mostrar el menú
                Console.WriteLine("Elija la opción deseada");
                Console.WriteLine("1. Agregar estudiante\n2. Ver estudiantes\n3. Agregar asignatura\n4. Ver asignaturas\n0. Salir");
                opcion = Console.ReadLine();

                Console.Clear(); // Limpia la consola antes de realizar la acción seleccionada

                if (opcion == "1")
                {
                    Console.Write("Digite ID del estudiante: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Digite el nombre del estudiante: ");
                    string nombre = Console.ReadLine();

                    estudiantes.Add(new Estudiante(id, nombre));
                    Console.WriteLine("Estudiante agregado con éxito!\n");
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Lista de estudiantes:");
                    foreach (var estudiante in estudiantes)
                    {
                        estudiante.MostrarDetalles();
                    }
                    Console.WriteLine();
                }
                else if (opcion == "3")
                {
                    Console.Write("Digite el código de la asignatura: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Digite el nombre de la asignatura: ");
                    string nombreAsignatura = Console.ReadLine();

                    asignaturas.Add(new Asignatura(codigo, nombreAsignatura));
                    Console.WriteLine("Asignatura agregada con éxito!\n");
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Lista de asignaturas:");
                    foreach (var asignatura in asignaturas)
                    {
                        asignatura.MostrarAsignatura();
                    }
                    Console.WriteLine();
                }
                else if (opcion == "0")
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opción inválida!\n");
                }

                // Esperar a que el usuario presione una tecla antes de limpiar la pantalla y mostrar el menú de nuevo
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}