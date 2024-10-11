using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modu
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
}